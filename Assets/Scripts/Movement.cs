using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rigidbody1;

    public int speed;

    // Update is called once per frame
    void Update()
    {
        float yvel = Input.GetAxis("Vertical") * speed;
        rigidbody1.velocity = new Vector2(0, yvel);
    }
}
