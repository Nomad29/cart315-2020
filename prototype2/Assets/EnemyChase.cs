/*****************

How to make enemy chase player. Basic AI
by Dee Va on Unity's forum

Short answer to a question about making an ennemy moving towards the player.

https://answers.unity.com/questions/274809/how-to-make-enemy-chase-player-basic-ai.html

******************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    public Transform Player;
    public float MoveSpeed = 1;
    public float MaxDist = 1;
    public float MinDist = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        transform.LookAt(Player);
        transform.position = new Vector3(transform.position.x, 1, transform.position.z);

        if (Vector3.Distance(transform.position, Player.position) >= MinDist)
        {
            transform.position += transform.forward * MoveSpeed * Time.deltaTime;

            if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
            {
                Application.LoadLevel(0);
            }
        }
    }
}
