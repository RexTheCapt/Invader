#region Usings

using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

// ReSharper disable MemberCanBePrivate.Global

#endregion

namespace Assets.Scripts.BulletScripts
{
    public class BulletSpecial : MonoBehaviour
    {
        public List<GameObject> BulletList = new List<GameObject>();
        public float Speed = 1;
        public float SpinSpeed = 2f;
        public bool DestructOnContact = false;
        public bool PreventControllerFromDestruction = false;

        [UsedImplicitly]
        void Update()
        {
            for (int i = BulletList.Count - 1; i >= 0; i--)
            {
                GameObject o = BulletList[i];

                if (o != null)
                {
                    Bullet b = o.GetComponent<Bullet>();

                    b.Speed = Speed;

                    b.DestroyOnContact = DestructOnContact;
                }
                else
                {
                    // ReSharper disable once ExpressionIsAlwaysNull
                    BulletList.Remove(o);
                }
            }

            if(BulletList.Count == 0)
                Destroy(gameObject);

            transform.rotation = Quaternion.Euler(new Vector3(0, SpinSpeed, 0) + transform.eulerAngles);
        }

        internal void Destruct(GameObject g)
        {
            if (PreventControllerFromDestruction)
                Destroy(g);
            else
                Destroy(gameObject);
        }
    }
}