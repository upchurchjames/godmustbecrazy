using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public float spawnTime = 5f;
    public Enemy enemy;
    public Transform[] spawnPoints;
    public int numEnemy1, numEnemy2, numEnemy3;

    void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    void Spawn()
    {
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
}
