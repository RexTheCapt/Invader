using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHit : MonoBehaviour
{
    public GameObject ParentGameObject;

    void OnTriggerEnter(Collider collider)
    {
        if(collider.tag == "Enemy")
        {
            Destroy(collider.gameObject);
            ParentGameObject.GetComponent<Bullet>().Destroy();
        }
    }
}
