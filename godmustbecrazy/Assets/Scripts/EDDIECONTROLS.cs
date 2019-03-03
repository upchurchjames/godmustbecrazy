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
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(left))
        {
            if (Input.GetKey(up))
            {
                movement = new Vector2(-player.MovementSpeed, player.MovementSpeed);
                rb.MovePosition(rb.position + movement);
            }

            if (Input.GetKey(down))
            {
                movement = new Vector2(-player.MovementSpeed, -player.MovementSpeed);
                rb.MovePosition(rb.position + movement);
            }

            movement = new Vector2(-player.MovementSpeed, 0);
            rb.MovePosition(rb.position + movement);
        }

        if (Input.GetKey(right))
        {
            if (Input.GetKey(up))
            {
                movement = new Vector2(player.MovementSpeed, player.MovementSpeed);
                rb.MovePosition(rb.position + movement);
            }

            if (Input.GetKey(down))
            {
                movement = new Vector2(player.MovementSpeed, -player.MovementSpeed);
                rb.MovePosition(rb.position + movement);
            }

            movement = new Vector2(player.MovementSpeed, 0);
            rb.MovePosition(rb.position + movement);
        }

        if (Input.GetKey(up))
        {
            if (Input.GetKey(left))
            {
                movement = new Vector2(-player.MovementSpeed, player.MovementSpeed);
                rb.MovePosition(rb.position + movement);
            }

            if (Input.GetKey(right))
            {
                movement = new Vector2(player.MovementSpeed, player.MovementSpeed);
                rb.MovePosition(rb.position + movement);
            }

            movement = new Vector2(0, player.MovementSpeed);
            rb.MovePosition(rb.position + movement);
        }

        if (Input.GetKey(down))
        {
            if (Input.GetKey(left))
            {
                movement = new Vector2(player.MovementSpeed, -player.MovementSpeed);
                rb.MovePosition(rb.position + movement);
            }

            if (Input.GetKey(right))
            {
                movement = new Vector2(player.MovementSpeed, -player.MovementSpeed);
                rb.MovePosition(rb.position + movement);
            }

            movement = new Vector2(0, -player.MovementSpeed);
            rb.MovePosition(rb.position + movement);
        }
    }
}
