using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUnit : Unit
{
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
