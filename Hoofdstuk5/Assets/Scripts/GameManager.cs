using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;               //nodig om het Text variable te maken

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    
    int score = 0;
    int lives = 3;

    public Text scoreText;          //deze variable gaan we dan in de scene aan het text gameObject linken

    bool gameOver = false;

    private void Awake(){
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncrimentScore(){
        score++;
        scoreText.text = score.ToString();      //score omvormen naar string en in het Text object steken
    }
    
    public void DecreaseLife(){
        if(lives > 1){
            lives--;
            print(lives);
        }
        else{
            gameOver = true;
            GameOver();
        }
    }

    public void GameOver(){
            print("GameOver");
    }
}
