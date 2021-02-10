using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public int sceneNumber;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            LoadLevel();
        }
        if(Input.GetMouseButtonDown(1)){
            RestartLevel();
        }
    }

    void LoadLevel(){
        SceneManager.LoadScene("level2");
        SceneManager.LoadScene(sceneNumber);
    }

    void RestartLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        print("reloaded level!");
    }
}
