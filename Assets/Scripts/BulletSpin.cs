using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpin : MonoBehaviour
{
    public float spinSpeed = 1f;

    void Update()
    {
        Vector3 rotationVector3 = new Vector3(0, spinSpeed, 0) + gameObject.transform.rotation.eulerAngles;

        gameObject.transform.rotation = Quaternion.Euler(rotationVector3);
    }
}
