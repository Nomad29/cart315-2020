using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomFall : MonoBehaviour
{

    public GameObject Player;
    int roll;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {   
        // Chance of 50% to fall from a platform
        roll = Random.Range(1, 4);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player && roll == 3)
        {
            gameObject.GetComponent<Collider>().enabled = false;
            Invoke("Respawn", 10.0f);
        }
    }

    void Respawn()
    {
        gameObject.GetComponent<Collider>().enabled = true;
    }
}
