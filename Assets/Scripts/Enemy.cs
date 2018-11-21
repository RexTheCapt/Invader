using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject PlayerGameObject;
    public DataHolder DataHolder;

    // Use this for initialization
    void Start()
    {
        gameObject.transform.LookAt(PlayerGameObject.transform.position);
        DataHolder.EnemyGameObjects.Add(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * 5;
    }
}
