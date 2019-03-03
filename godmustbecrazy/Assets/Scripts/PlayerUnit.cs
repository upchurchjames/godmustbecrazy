using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnit : Unit
{
    public GameObject instance;
    public Rigidbody2D body;

    public enum EnemyType
    {
        Tank,
        Marksman,
        Mage,
        Scout
    }

    // Start is called before the first frame update
    void Start()
    {
        instance = gameObject;
        body = instance.GetComponent<Rigidbody2D>();
        instance.tag = "Player";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InflictDamage(EnemyUnit prey, float damageAmount)
    {
        prey.UpdateHealth(-damageAmount);
    }
}
