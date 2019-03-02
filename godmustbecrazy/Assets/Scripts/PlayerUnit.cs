using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnit : Unit
{
    private GameObject instance;

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
        instance = Instance;
        instance.tag = "Player";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InflictDamage(EnemyUnit prey, float damageAmount)
    {
        prey.UpdateHealth(-damageAmount);
    }
}
