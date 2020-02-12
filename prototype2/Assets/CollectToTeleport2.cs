using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectToTeleport2 : MonoBehaviour
{
    private Transform PlayerTransform;
    public Transform TeleportGoal;
    public GameObject Player;
    private static int PlayerScore;
    public GameObject Instruction;
    public GameObject Instruction2;

    public int Score
    {
        get { return Score; }
        set { Score = value; }
    }

    void Start()
    {
        PlayerTransform = Player.transform;
        Instruction.gameObject.SetActive(false);
        Instruction2.gameObject.SetActive(false);
    }

    void Update()
    {
        PlayerScore = Pickup.Score; 
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player && PlayerScore != 8)
        {
            Instruction.gameObject.SetActive(true);
        }

        else if (other.gameObject == Player && PlayerScore == 8)
        {
            Instruction2.gameObject.SetActive(true);
        }
    }

    public void OnTriggerStay()
    {
        if (Input.GetKeyDown(KeyCode.E) && PlayerScore == 8)
        {
            PlayerTransform.position = TeleportGoal.position;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject == Player)
        {
            Instruction.gameObject.SetActive(false);
            Instruction2.gameObject.SetActive(false);
        }
    }
}
