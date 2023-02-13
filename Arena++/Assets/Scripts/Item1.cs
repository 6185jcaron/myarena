using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item1 : MonoBehaviour
{
    //1
    public PlayerBehavior player;
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerBehavior>();
    }
    void OnCollisionEnter(Collision collision)
    {
        //2
        if (collision.gameObject.name == "Player")
        {
            //3
            Destroy(this.transform.parent.gameObject);
            //4
            Debug.Log("Item Collected!");
            player.moveMultiplier = 3f;
            Debug.Log("TEST");
        }





    }
}
