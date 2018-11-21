using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataHolder : MonoBehaviour
{
    public List<GameObject> EnemyGameObjects;

    private float cleanTimer;

    void Update()
    {
        foreach (GameObject o in EnemyGameObjects)
        {
            if (o == null)
                EnemyGameObjects.Remove(o);
        }
    }
}
