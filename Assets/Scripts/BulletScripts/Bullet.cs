#region Usings

using JetBrains.Annotations;
using UnityEngine;
// ReSharper disable MemberCanBePrivate.Global

#endregion

namespace Assets.Scripts.BulletScripts
{
    public class Bullet : MonoBehaviour
    {
        public bool DestroyOnContact = true;
        public BulletSpecial BulletSpecial;
        public float Speed = 5f;
        public Vector3 StartPosition;
        public float DistanceTraveled;
        public DataHolder DataHolder;

        [UsedImplicitly]
        private void Start()
        {
            StartPosition = gameObject.transform.position;

            // Register to special bullet script
            if (BulletSpecial != null)
            {
                BulletSpecial.BulletList.Add(gameObject);
            }
        }

        // Update is called once per frame
        [UsedImplicitly]
        private void Update()
        {
            DistanceTraveled = Vector3.Distance(gameObject.transform.position, StartPosition);

            if (Vector3.Distance(gameObject.transform.position, StartPosition) > 50f)
                Destruct();

            gameObject.transform.position += transform.forward * Time.deltaTime * Speed;
        }

        private void Destruct()
        {
            if (BulletSpecial != null)
                BulletSpecial.Destruct(gameObject);
            Destroy(gameObject);
        }

        public void DestructOnContact()
        {
            if (DestroyOnContact)
            {
                if (BulletSpecial == null)
                {
                    DataHolder.NukeCharge += DataHolder.NukeChargeAdd;
                    DataHolder.ShieldCharge += DataHolder.ShieldChargeAdd;

                    if (DataHolder.NukeCharge > 1f)
                        DataHolder.NukeCharge = 1f;

                    if (DataHolder.ShieldCharge > 1f)
                        DataHolder.ShieldCharge = 1f;
                }

                Destruct();
            }
        }
    }
}