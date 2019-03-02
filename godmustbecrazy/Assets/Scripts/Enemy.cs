using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Unit
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
        Health = 100;
        Strength = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    EnemyType UpgradeEnemy(EnemyType type)
    {
        return type;
    }
}
