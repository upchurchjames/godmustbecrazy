using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public float Health;
    public float Strength;
    public float MovementSpeed;
    public string meshLocation;
    public GameObject Instance;
    public Rigidbody body;

    // Awake is called before the first frame update
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateGameObject()
    {
        Instance = new GameObject();
        
    }

    public void AddMesh()
    {
        Instance.AddComponent<MeshFilter>();
        Instance.GetComponent<MeshFilter>().mesh = (Mesh)Resources.Load(meshLocation, typeof(Mesh));  
    }

    public void AddRigidBody()
    {
        Instance.AddComponent<Rigidbody2D>();
    }

    public void UpdateHealth(float changeAmount)
    {
        Health += changeAmount;

        if (Health > 100.0f)
            Health = 100.0f;

        if (Health <= 0)
            Die();
    }

    public void Die()
    {
        Destroy(Instance);
    }
}
