using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool gameOver = false;
    void Awake(){
        if(instance == null){
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame(){
        UIManager.instance.GameStart();
        ScoreManager.instance.startScore();
        GameObject.Find("PlatformSpawner").GetComponent<PlatformSpawner>().StartSpawning();     //bij starten van game: zoek de spawner, neem de het scriptcomponent en voer de startspawning functie uit;
    }

    public void GameOver(){
        UIManager.instance.GameOver();
        ScoreManager.instance.stopScore();
        gameOver = true;
    }
}
