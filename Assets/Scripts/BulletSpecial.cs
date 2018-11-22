#region Usings

using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

#endregion

namespace Assets.Scripts
{
    public class BulletSpecial : MonoBehaviour
    {
        public float Speed = 1;
        public List<GameObject> BulletList = new List<GameObject>();
        public float SpinSpeed = 2f;
        public bool DestructOnContact = false;
        public bool PreventControllerFromDestruction = false;

        [UsedImplicitly]
        void Update()
        {
            foreach (GameObject o in BulletList)
            {
                if (o != null)
                {
                    Bullet b = o.GetComponent<Bullet>();

                    b.Speed = Speed;

                    b.DestroyOnContact = DestructOnContact;
                }
            }

            transform.rotation = Quaternion.Euler(new Vector3(0, SpinSpeed, 0) + transform.eulerAngles);
        }

        internal void Destruct(GameObject g)
        {
            if (PreventControllerFromDestruction)
                Destroy(g);
            else
                Destroy(g);
        }
    }
}