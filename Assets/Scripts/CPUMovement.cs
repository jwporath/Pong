using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPUMovement : MonoBehaviour
{
    public Rigidbody2D CPURigBod;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        float yvel;
        if(GameObject.FindGameObjectWithTag("Ball").transform.position.y > CPURigBod.position.y)
        {
            yvel = 1 * speed;
            CPURigBod.velocity = new Vector2(0, yvel);
        }
        else if(GameObject.FindGameObjectWithTag("Ball").transform.position.y < CPURigBod.position.y)
        {
            yvel = -1 * speed;
            CPURigBod.velocity = new Vector2(0, yvel);
        }
    }
}
