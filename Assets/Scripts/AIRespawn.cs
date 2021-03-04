using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIRespawn : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    private int xPos;
    private int zPos;
    [SerializeField] private int enemyCount;
    [SerializeField] private float waitSeconds;
    [SerializeField] private int totalEnemies;
    private GameObject[] AICount;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemySpawn());
    }
    private void Update()
    {
        AICount = GameObject.FindGameObjectsWithTag("Enemy");
        if(AICount.Length < totalEnemies)
        {
            enemyCount = AICount.Length;
            StartCoroutine(EnemySpawn());
        }
    }

    // use coroutine to spawn enemies randomly between a portion of the map
    IEnumerator EnemySpawn()
    {
        Debug.Log("Starting");
        while(enemyCount < totalEnemies)
        {

            Debug.Log("StartingRespawn");
            xPos = Random.Range(-20, 10);
            zPos = Random.Range(-10, 10);
            Instantiate(enemy, new Vector3(xPos, .1f, zPos), Quaternion.identity);
            Debug.Log("StartingTimer");
            yield return new WaitForSeconds(.1f);
            enemyCount += 1;
        }
    }

}
