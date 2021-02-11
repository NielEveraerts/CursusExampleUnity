using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour  //nu kan dragon en robot ook de functionaliteiten van Unity gebruiken, ook kan de dragon script aan een gameObject toegevoegd worden
{
    public void Attack(){           //dit kan door iedereen gebruikt worden
        Debug.Log("Enemy Attack");
        GetComponent<Renderer>().material.color = Color.red;
    }

    private void Iets(){            //dit kan niet gebruikt worden door classes die overdragen van Enemy

    }

    protected void Defend(){        //dit kan enkel gebruikt worden door klassen die Enemy inheriten, dus enemy.Defend() zou niet gaan maaar dragon.Defend() wel
        Debug.Log("Enemy Defend");
    }
}
