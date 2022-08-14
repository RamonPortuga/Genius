/* Código usado para os Menu's (para Teclado e para Joystick)
 * e também controla as áudio descrições de todas as cenas*/ 
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuScript : MonoBehaviour
{

    //int index = 0;
    public int totalButton = 4;

    //bool firstMoviment = true;
    //bool keypad = false;

    public AudioSource audioDescription;


    public AudioSource audioButtonGenius;
    public AudioSource audioButtonInstructions;
    public AudioSource audioButtonTester;
    public AudioSource audioButtonQuit;

    public static bool menuActived = false;

    public static bool pause = true;

    // Start is called before the first frame update
    void Start()
    {
        menuActived = false;
        //As condicionais abaixo servem para controlar as AudioDescrições
        if (SceneManager.GetActiveScene().name == "Menu" || SceneManager.GetActiveScene().name == "MenuJoystick")
        {
            audioDescription.Play();
            pause = false;
        }
        else if (SceneManager.GetActiveScene().name == "Instructions" || SceneManager.GetActiveScene().name == "InstructionsJoystick")
        {
            audioDescription.Play();
            pause = false;
        }
        else if (SceneManager.GetActiveScene().name == "Tester" || SceneManager.GetActiveScene().name == "TesterJoystick")
        {
            audioDescription.Play();
            pause = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //As linhas abaixo servem para controlar as AudioDescrições
        //Debug.Log(pause);
        if (SceneManager.GetActiveScene().name == "Menu")
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (pause == false)
                {
                    audioDescription.Pause();
                    pause = true;
                }
                else
                {
                    audioDescription.Play();
                    pause = false;
                }
            }
        }
        else if (SceneManager.GetActiveScene().name == "MenuJoystick")
        {
            if (Input.GetButtonDown("RB"))
            {
                if (pause == false)
                {
                    audioDescription.Pause();
                    pause = true;
                }
                else
                {
                    audioDescription.Play();
                    pause = false;
                }
            }
        }
        else if (SceneManager.GetActiveScene().name == "Instructions")
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (pause == false)
                {
                    audioDescription.Pause();
                    pause = true;
                }
                else
                {
                    audioDescription.Play();
                    pause = false;
                }
            }
        }
        else if (SceneManager.GetActiveScene().name == "InstructionsJoystick")
        {
            if (Input.GetButtonDown("RB"))
            {
                if (pause == false)
                {
                    audioDescription.Pause();
                    pause = true;
                }
                else
                {
                    audioDescription.Play();
                    pause = false;
                }
            }
        }
        else if (SceneManager.GetActiveScene().name == "Tester" )
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (pause == false)
                {
                    audioDescription.Pause();
                    pause = true;
                }
                else
                {
                    audioDescription.Play();
                    pause = false;
                }
            }
        }
        else if (SceneManager.GetActiveScene().name == "TesterJoystick")
        {
            if (Input.GetButtonDown("RB"))
            {
                if (pause == false)
                {
                    audioDescription.Pause();
                    pause = true;
                }
                else
                {
                    audioDescription.Play();
                    pause = false;
                }
            }
        }

        //Comentei esse código abaixo pq ele pode ser útil no futuro
        //Ele serve para navegar pelo menu principal utilizando apenas
        //as setas para baixo e para cima. De modo similar a alguns jogos
        //tradicionais, como os de PS2.
        /*
        if (keypad == true)
        {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                index = index + 1;
                if (index == 1 || index == 5)
                {
                    if (index == 5)
                    {
                        index = 1;
                    }
                    audioButtonGenius.Play();
                }
                else if (index == 2)
                {
                    audioButtonInstructions.Play();
                }
                else if (index == 3)
                {
                    audioButtonTester.Play();
                }
                else if (index == 4)
                {
                    audioButtonQuit.Play();
                    //index = 0;
                }

                firstMoviment = false;
            }

            if (firstMoviment == false)
            {
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    index = index - 1;
                    if (index == 1)
                    {
                        audioButtonGenius.Play();
                    }
                    else if (index == 2)
                    {
                        audioButtonInstructions.Play();
                    }
                    else if (index == 3)
                    {
                        audioButtonTester.Play();
                    }
                    else if (index == 4 || index == 0)
                    {
                        if (index == 0)
                        {
                            index = 4;
                        }
                        audioButtonQuit.Play();
                    }
                }
            }

            Debug.Log(index);

            if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
            {
                if (index == 1)
                {
                    SceneManager.LoadScene("Genius");
                }
                else if (index == 2)
                {
                    SceneManager.LoadScene("Instructions");
                }
                else if (index == 3)
                {
                    SceneManager.LoadScene("Tester");
                }
                else if (index == 4)
                {
                    menuActived = true;
                    SceneManager.LoadScene("ExitConfirmation");
                }
            }
        }
        */
    }
}
