using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D collide)
    {
        if(collide.tag == "border")
        {
            Destroy(this.gameObject);
        }
        else if(collide.tag == "Player")
        {
            Destroy(player.gameObject);
        }
    }


}
