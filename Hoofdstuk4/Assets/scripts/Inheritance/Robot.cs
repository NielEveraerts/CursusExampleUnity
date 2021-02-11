using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour
{
    private void Start(){
        Robot robot = new Robot();
        robot.Attack();

        Robot robot2 = new BlueRobot();  //aangezien een BlueRobot een child is van Robot kunnen we zeggen dat Robot = new BlueRobot
        robot2.Attack();

        Robot robot3 = new RedRobot();
        robot3.Attack();

        Robot robotTest = new BlueRobot();  //aangezien robot geen Attack2 heeft en robotTest een Robot is ga je Attack2 van de blueRobot niet kunnen gebruiken
        //robotTest.Attack2();
    }
    public virtual void Attack(){   //maak de standaard functie virtual zodat de childclasses de standaard attack kunnen overschrijven
        print("Robot Attack");
    }
}

public class BlueRobot : Robot {
    public override void Attack(){  //overschrijf de standaard Attack functie
        print("BlueRobot Attack");
    }
    public void Attack2(){
        print("BlueRobot Attack2");
    }

}

public class RedRobot : Robot {
    public override void Attack(){
        print("RedRobot Attack");
    }
}



