#region Usings

using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

#endregion

namespace Assets.Scripts
{
    public class BulletSpecial : MonoBehaviour
    {
        #region Type class

        [Serializable]
        private class Type
        {
            public bool Nuke = false;
        }

        [SerializeField]
        Type type = new Type();

        #endregion

        public float Speed = 1;
        public List<GameObject> BulletList = new List<GameObject>();

        [Header("Nuke setting")]
        public float SpinSpeed = 2f;

        [UsedImplicitly]
        void Update()
        {
            foreach (GameObject o in BulletList)
            {
                if (o != null)
                {
                    Bullet b = o.GetComponent<Bullet>();

                    b.Speed = Speed;
                }
            }

            if (type.Nuke)
            {
                transform.rotation = Quaternion.Euler(new Vector3(0, SpinSpeed, 0) + transform.eulerAngles);
            }
        }

        internal void Destruct()
        {
            Destroy(gameObject);
        }
    }
}