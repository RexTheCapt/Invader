using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Vector3 startPosition;
    public float speed = 2f;
    public GameObject SpecialBulletControllerGameObject;
    public bool destroyOnContact = true;

    void Start()
    {
        startPosition = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(gameObject.transform.position, startPosition) > 55f)
            Destroy(gameObject);

        gameObject.transform.position += transform.forward * Time.deltaTime * speed;
    }

    public void Destroy()
    {
        if (destroyOnContact)
        {
            if (SpecialBulletControllerGameObject != null)
                Destroy(SpecialBulletControllerGameObject);
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
