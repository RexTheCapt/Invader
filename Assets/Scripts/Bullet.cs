#region Usings

using JetBrains.Annotations;
using UnityEngine;

#endregion

namespace Assets.Scripts
{
    public class Bullet : MonoBehaviour
    {
        public bool DestroyOnContact = true;
        public BulletSpecial BulletSpecial;
        public float Speed = 5f;
        public Vector3 StartPosition;

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
            if (Vector3.Distance(gameObject.transform.position, StartPosition) > 55f)
                Destruct();

            gameObject.transform.position += transform.forward * Time.deltaTime * Speed;
        }

        private void Destruct()
        {
            if (BulletSpecial != null)
                BulletSpecial.Destruct();
            Destroy(gameObject);
        }

        public void DestructOnContact()
        {
            if (DestroyOnContact)
            {
                Destruct();
            }
        }
    }
}