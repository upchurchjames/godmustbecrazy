using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerUnit player;
    public float startTimeBetweenAttacks;
    public Transform attackPos;
    public float attackRange;
    public LayerMask whatIsEnemies;
    public Animator playerAnimation;
    private float timeBetweenAttacks;
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

        Attack();
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

    void Attack()
    {
        if(timeBetweenAttacks <= 0)
        {
            playerAnimation.SetTrigger("attack");

            if (Input.GetKey(KeyCode.Space))
            {

                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemies);

                for(int i = 0; i < enemiesToDamage.Length; i++)
                {
                    player.InflictDamage(enemiesToDamage[i].GetComponent<EnemyUnit>(), player.Strength);
                }
            }

            timeBetweenAttacks = startTimeBetweenAttacks;
        }
        else
        {
            timeBetweenAttacks -= Time.deltaTime;
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }

    void Flip()
    {
        isFacingRight = !isFacingRight;

        Vector2 theScale = player.transform.localScale;
        theScale.x *= -1;
        player.transform.localScale = theScale;

    }
}
