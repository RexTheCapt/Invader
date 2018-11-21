using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public DataHolder DataHolder;
    public GameObject BulletGameObject;
    public GameObject SpinBulletGameObject;
    public bool autoFire = false;

    void Update()
    {
        if (Input.GetButtonDown("Fire1") || autoFire)
        {
            Fire(BulletGameObject);
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            Fire(SpinBulletGameObject, false);
        }
    }

    public void Fire(GameObject bullet, bool destroyOnContact = true)
    {
        GameObject bulletInstantiate = Instantiate(bullet);
        bulletInstantiate.transform.position = gameObject.transform.position;
        bulletInstantiate.transform.rotation = gameObject.transform.rotation;
        bulletInstantiate.GetComponent<Bullet>().destroyOnContact = destroyOnContact;
    }
}
