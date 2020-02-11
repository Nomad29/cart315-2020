using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    private Transform PlayerTransform;
    public Transform TeleportGoal;
    public GameObject Player;
    public GameObject Instruction;

    void Start()
    {
        PlayerTransform = Player.transform;
        Instruction.gameObject.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {
            Instruction.gameObject.SetActive(true);
        }
    }

    public void OnTriggerStay()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            PlayerTransform.position = TeleportGoal.position;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject == Player)
        {
            Instruction.gameObject.SetActive(false);
        }
    }
}
