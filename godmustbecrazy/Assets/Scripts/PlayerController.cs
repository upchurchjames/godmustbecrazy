using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerUnit player;
    private Rigidbody2D body;
    private float horizontal, vertical;
    Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        body = player.body;
        body.velocity = Vector2.zero;
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
        body.MovePosition(body.position + movement);
    }
}
