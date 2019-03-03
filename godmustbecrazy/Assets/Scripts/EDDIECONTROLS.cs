using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EDDIECONTROLS : MonoBehaviour
{
    public PlayerUnit player;
    private Vector2 movement;


    public KeyCode left;
    public KeyCode right;
    public KeyCode up;
    public KeyCode down;
    public KeyCode attack;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        movement = Vector2.zero; 
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        movement = Vector2.zero;

        if (Input.GetKey(left))
        {
            movement += Vector2.left;
        }

        if (Input.GetKey(right))
        {
            movement += Vector2.right;
        }

        if (Input.GetKey(up))
        {
            movement += Vector2.up;
        }

        if (Input.GetKey(down))
        {
            movement += Vector2.down;
            
        }

        movement.Normalize();
        rb.MovePosition(rb.position + movement * player.MovementSpeed);
    }
}
