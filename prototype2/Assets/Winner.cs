using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winner : MonoBehaviour
{

    public GameObject Player;
    public GameObject text;

    // Start is called before the first frame update
    void Start()
    {
        text.gameObject.SetActive(false);
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
            text.gameObject.SetActive(true);
        }
    }

}
