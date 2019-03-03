using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EDDIECONTROLS : MonoBehaviour
{
    public float moveSpeed = 18;

    public KeyCode left;
    public KeyCode right;
    public KeyCode up;
    public KeyCode down;
    public KeyCode attack;

    private Rigidbody2D theRB;

    // Start is called before the first frame update
    void Start()
    {
        theRB = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(left))
        {
            theRB.velocity = new Vector2(-moveSpeed, theRB.velocity.y);

            if (Input.GetKey(up))
            {

            }

            if (Input.GetKey(down))
            {

            }

            if (Input.GetKey(right))
            {

            }
        }

        else if (Input.GetKey(right))
        {
            theRB.velocity = new Vector2(moveSpeed, theRB.velocity.y);
        }

        else if (Input.GetKey(up))
        {
            theRB.velocity = new Vector2(moveSpeed, theRB.velocity.x);
        }

        else if (Input.GetKey(down))
        {
            theRB.velocity = new Vector2(-moveSpeed, theRB.velocity.x);
        }

        else
        {
            theRB.velocity = new Vector2(0, 0);
        }

    }
}
