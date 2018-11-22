#region Usings

using JetBrains.Annotations;
using UnityEngine;

#endregion

namespace Assets.Scripts
{
    public class Bullet : MonoBehaviour
    {
        public bool DestroyOnContact = true;
        public GameObject SpecialBulletControllerGameObject;
        public float Speed = 2f;
        public Vector3 StartPosition;

        [UsedImplicitly]
        private void Start()
        {
            StartPosition = gameObject.transform.position;
        }

        // Update is called once per frame
        [UsedImplicitly]
        private void Update()
        {
            if (Vector3.Distance(gameObject.transform.position, StartPosition) > 55f)
                Destroy(gameObject);

            gameObject.transform.position += transform.forward * Time.deltaTime * Speed;
        }

        public void Destroy()
        {
            if (DestroyOnContact)
            {
                if (SpecialBulletControllerGameObject != null)
                    Destroy(SpecialBulletControllerGameObject);
                else
                    Destroy(gameObject);
            }
        }
    }
}