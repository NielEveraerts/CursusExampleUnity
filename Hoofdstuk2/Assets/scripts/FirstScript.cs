using UnityEngine;

public class FirstScript : MonoBehaviour {
    // Start is called before the first frame update

    int score = 10;
    public float speed;
    char character = 'A';
    public int scoreIf;
    public string myName = "naam"; //nu kan name ook in unity aangepast worden 
    bool playing;

    public bool killPlayer;
    void Start() {
        //print("My nam is " + nametest);
        //score = 39; 
        TestFunction();
        int returnedNumber = ReturnDouble(5);
        print(returnedNumber);

        PrintName("Niel");
        PrintName(myName);

        if(score <= 0){
            print("game over"); 
        }
        else if(score > 0 && score < 10){
            print("Level 1"); 
        }
        else if(score > 10){
            print("Level 2"); 
        }
        else{
            print("Gama running"); 
        }

        if(myName == "Niel"){
            print("name is Niel");
        }
        else{
            print("name is not Niel");
        }
        
        if(playing){
            print("playing");
        }
        else{
            print("gameover");
        }
        
        if(!playing){
            print("gameover");
        }
        else{
            print("playing");
        }
    }

    // Update is called once per frame -> dit de gameloop en hiermee kan je voor inputs checken enzo
    void Update(){
        //TestFunction();

        if(killPlayer){
                Destroy(gameObject, 2f); //destroy het gameObject dat verbonden is met dit script, dit na 2 seconden -> f achter 2 omdat de destroy methode een float verwacht
        }
    }

    void OnEnable(){
        print("ONENABLE");
    }

    void OnDisable(){
        print("ONDISABLE");
    }

    void TestFunction(){
        print("a");
        print("b");
        print("c");
        print("d");
        transform.Translate(speed,0,0); //beweeg het gameobject in de x-as
    }

    int ReturnDouble(int input){
        return (input * 2);
    }

    void PrintName(string name){
        print("My name is: "+ name);
    }
}
