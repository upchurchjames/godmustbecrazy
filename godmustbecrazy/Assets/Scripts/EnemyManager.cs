using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public float spawnTime = 5f;
    public Enemy enemy;
    public Transform[] spawnPoints;

    void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    void Spawn()
    {
        GameObject[] temp = new GameObject[25];
        Transform[] tempTrans = new Transform[25];

        for (int i = 0; i < 25; i++)
        {
            temp[i] = new GameObject();
            temp[i].AddComponent<Transform>();
            tempTrans[i] = temp[i].transform;
        }

        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
}
