using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;               //nodig om het Text variable te maken
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    
    int score = 0;
    int lives = 3;

    public Text scoreText;          //deze variable gaan we dan in de scene aan het text gameObject linken
    public GameObject livesHolder;  //het paneel waarin de harten zitten
    public GameObject gameOverPanel;


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
        if(!gameOver){
            score++;
            scoreText.text = score.ToString();      //score omvormen naar string en in het Text object steken
        }
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
        CandySpawner.instance.StopSpawning();                                           //CandySpawner heeft een public instance en zo kunnen we aan de stopfunctie 
        GameObject.Find("Player").GetComponent<PlayerController>().canMove = false;     //canMove is public dus gaan we de juiste component zoeken en daarin de canMove false zetten
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Candy");              //zoak alle candies (via tag) en stop die in array
        foreach (var item in objects)                                                   //lus door array van gameObjecten
        {
            item.GetComponent<CandyScript>().DespawnCandy();                            //verwijder elk object dat nog zou aan het vallen zijn
        }
        gameOverPanel.SetActive(true);
    }

    public void Restart(){
        SceneManager.LoadScene("Game");
    }

    public void ToMenu(){
        SceneManager.LoadScene("Menu");
    }
}
