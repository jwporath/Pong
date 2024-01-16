using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPUGoal : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Ball")
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().PlayerScored();
        }
    }
}
