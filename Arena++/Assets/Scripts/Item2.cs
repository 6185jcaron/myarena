using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item2 : MonoBehaviour
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
            player.jumpMultiplier = 2f;
            Debug.Log("TEST");
        }





    }
}
