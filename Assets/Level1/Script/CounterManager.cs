using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterManager : MonoBehaviour
{
    public int mushrooms = 0;
    public Text textMushroomScore;

    public int lives = 3;
    public Text textLivesScore;

    public int counterTime= 500;
    public Text textCounterTime;
    
    // Start is called before the first frame update
    void Start()
    {
        textLivesScore.text = lives.ToString();
        textCounterTime.text = counterTime.ToString();
        InvokeRepeating("ContadorTiempo", 1f, 1f);
    }


    public void addMushroom(){
        mushrooms++;
        textMushroomScore.text = mushrooms.ToString();
    }

     
    public void addLives(){
        lives++;
        textLivesScore.text = lives.ToString();
    }

    public void removeLives(){
        lives--;
        if (lives == 0){
            Debug.Log("Contiuar o Cerrar el juego");
        }
        textLivesScore.text = lives.ToString();
    }


    void ContadorTiempo(){
        counterTime--;
        textCounterTime.text = counterTime.ToString();
    }
}
