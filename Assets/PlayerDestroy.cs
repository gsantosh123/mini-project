using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDestroy : MonoBehaviour
{
    private GameObject Player;
    public Transform target;
    void Start()
    {
       Player = GameObject.FindGameObjectWithTag("Player"); 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Border")
        {
            Destroy(this.gameObject);
        }
        else if(collision.tag=="Player")
        {
            Destroy(Player.gameObject);
        }
    }
}
