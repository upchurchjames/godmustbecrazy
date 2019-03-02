using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public float Health;
    public float Strength;
    public float MovementSpeed;
    public MeshFilter Mesh;
    public GameObject Object;

    // Awake is called before the first frame update
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateHealth(float changeAmount)
    {
        Health += changeAmount;

        if (Health > 100.0f)
            Health = 100.0f;

        if (Health <= 0)
            Die();
    }

    void Die()
    {

    }
}
