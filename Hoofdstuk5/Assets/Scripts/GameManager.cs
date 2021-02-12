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
    public GameObject livesHolder;  //het paneel waarin de harten zitten

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
        if(lives > 0){
            lives--;
            print(lives);
            livesHolder.transform.GetChild(lives).gameObject.SetActive(false);  //aangezien lives zakt naar 2 -> en het derde childObject een index heeft van 2 kunnen we simpelweg zeggen: zet childObject met index lives inactief
        }
        if(lives <= 0){
            gameOver = true;
            GameOver();
        }
    }

    public void GameOver(){
            print("GameOver");
    }
}
