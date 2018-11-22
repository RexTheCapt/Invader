#region Usings

using JetBrains.Annotations;
using UnityEngine;

#endregion

namespace Assets.Scripts
{
    public class PlayerShoot : MonoBehaviour
    {
        public bool AutoFire = false;
        public GameObject BulletGameObject;
        public DataHolder DataHolder;
        public GameObject NukeBulletGameObject;
        public GameObject BulletShieldGameObject;

        [UsedImplicitly]
        private void Update()
        {
            if (Input.GetButtonDown("Fire1") || AutoFire) Fire(BulletGameObject);

            if(Input.GetKeyDown(KeyCode.X)) Fire(NukeBulletGameObject);

            if(Input.GetKeyDown(KeyCode.Z)) Fire(BulletShieldGameObject);
        }

        public void Fire(GameObject bullet)
        {
            GameObject bulletInstantiate = Instantiate(bullet);
            bulletInstantiate.transform.position = gameObject.transform.position;
            bulletInstantiate.transform.rotation = gameObject.transform.rotation;
        }
    }
}