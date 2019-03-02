using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUnit : Unit
{
    private GameObject instance;
    private Rigidbody2D body;

    public enum EnemyType
    {
        Seraph,
        Angel,
        JesusChrist
    }
    
    public EnemyType type;

    // Start is called before the first frame update
    void Start()
    {
        instance = gameObject;
        body = instance.GetComponent<Rigidbody2D>();
        instance.tag = "Enemy";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InflictDamage(PlayerUnit prey, float damageAmount)
    {
        prey.UpdateHealth(-damageAmount);
    }

    EnemyType UpgradeEnemy(EnemyType type)
    {
        return type;
    }
}
