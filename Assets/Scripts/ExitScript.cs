/*Código usado na Scene "ExitConfirmation" 
 * e "ExitConfirmationJoystick"*/
using UnityEngine.SceneManagement;
using UnityEngine;

public class ExitScript : MonoBehaviour
{

    public void selectMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    // Sai do Jogo
    public void quitGame()
    {
        Application.Quit();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "ExitConfirmation")
        {
            if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1))
            {
                quitGame();
            }
            else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2))
            {
                //Debug.Log("Entrou");
                selectMenu();
            }
        }
    }
}
