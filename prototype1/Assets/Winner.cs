using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winner : MonoBehaviour
{

    public GameObject Player;
    public GameObject tex;

    // Start is called before the first frame update
    void Start()
    {
        tex.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {
            gameObject.GetComponent<Renderer>().enabled = false;
            tex.gameObject.SetActive(true);
        }
    }

}
