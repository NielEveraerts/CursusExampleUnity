using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Dragon : Enemy
{
    public bool isAttacking = false;

    private void Update(){
        if(isAttacking){
            Attack();
            base.Attack();          //hiermee kan je de attack van de enemy klasse gebruiken ookal hebben we een attack functie in deze klasse
        }
    }

    void Attack(){                  //standaard gaat dragon nu zijn eigen Attack() gebruiken ipv die van enemy
        print("Dragon Attack");
    }
}
