using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject EnemyGameObject;
    public DataHolder DataHolder;
    public bool autoSpawn = false;
    public int quantity = 1;

    private RandomCircle rc;

    void Start()
    {
        rc = gameObject.GetComponent<RandomCircle>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space) || autoSpawn)
        {
            for (int i = 0; i < quantity; i++)
            {
                GameObject enemyInstantiate = Instantiate(EnemyGameObject);
                enemyInstantiate.gameObject.GetComponent<Enemy>().PlayerGameObject = gameObject;
                enemyInstantiate.transform.position = rc.GetVector3(gameObject.transform.position, 50f);
                enemyInstantiate.GetComponent<Enemy>().DataHolder = DataHolder;
            }
        }
    }
}
