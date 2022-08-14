using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScoreScript : MonoBehaviour
{
    public bool endGame = false;
    public float countdownGameOver = 0f;
    public int score = 0;

    public AudioSource zeroPontos;
    public AudioSource umPonto;
    public AudioSource doisPontos;
    public AudioSource tresPontos;
    public AudioSource quatroPontos;
    public AudioSource cincoPontos;
    public AudioSource seisPontos;
    public AudioSource setePontos;
    public AudioSource oitoPontos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        endGame = ThinkerScript.endGame;
        score = ThinkerScript.score;
        if (endGame == true)
        {
            countdownGameOver += Time.deltaTime;
            if (countdownGameOver >= 12)
            {
                if (score == 0)
                {
                    zeroPontos.Play();
                }
                else if (score == 1)
                {
                    umPonto.Play();
                }
                else if (score == 2)
                {
                    doisPontos.Play();
                }
                else if (score == 3)
                {
                    tresPontos.Play();
                }
                else if (score == 4)
                {
                    quatroPontos.Play();
                }
                else if (score == 5)
                {
                    cincoPontos.Play();
                }
                else if (score == 6)
                {
                    seisPontos.Play();
                }
                else if (score == 7)
                {
                    setePontos.Play();
                }
                else if (score == 8)
                {
                    oitoPontos.Play();
                }
            }
        }
        */
    }
}
