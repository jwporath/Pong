using System.Collections;
using System.Collections.Generic;
// using TreeEditor;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rigbod;
    public Vector3 StartPosition;

    // Start is called before the first frame update
    void Start()
    {
        StartPosition = transform.position;
        Launch();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Launch()
    {
        int x = 0;
        int y = 0;

        // Randomly select direction
        while(x == 0) // loops to guarantee some horizontal movement
        {
            x = Random.Range(-1, 2);
        }
        
        while(y == 0) // loops to guarantee some vertical movement
        {
            y = Random.Range(-1, 2);
        }
        
        // apply velocity to rigidbody
        Vector2 Vel = new Vector2(speed * x, speed *y);
        rigbod.velocity = Vel;
    }

    public void ResetPos()
    {
        // Stop velocity
        rigbod.velocity = new Vector2(0, 0);
        // Return ball to start position
        transform.position = StartPosition;
        // Launch ball to begin again
        Launch();
    }
}
