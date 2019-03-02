using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerUnit player;
    private Rigidbody2D body;
    private float horizontal, vertical;
    private Vector2 movement;
    private bool isFacingRight;

    // Start is called before the first frame update
    void Start()
    {
        body = player.body;
        body.velocity = Vector2.zero;
        isFacingRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");        
    }

    void FixedUpdate()
    {
        movement = new Vector2(horizontal, vertical);
        movement = movement.normalized * player.MovementSpeed;
        movement *= Time.fixedDeltaTime;
        Move();
    }

    void Move()
    {
        if((horizontal > 0.0f && !isFacingRight) || (horizontal < 0.0f && isFacingRight))
        {
            Flip();
        }

        body.MovePosition(body.position + movement);
    }

    void Flip()
    {
        isFacingRight = !isFacingRight;

        Vector2 theScale = player.transform.localScale;
        theScale.x *= -1;
        player.transform.localScale = theScale;

    }
}
