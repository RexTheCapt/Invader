#region Usings

using Assets.Scripts.BulletScripts;
using JetBrains.Annotations;
using UnityEngine;
// ReSharper disable MemberCanBePrivate.Global

#endregion

namespace Assets.Scripts.PlayerScripts
{
    public class PlayerShoot : MonoBehaviour
    {
        public bool AutoFire = false;
        public DataHolder DataHolder;
        public GuiController GuiController;
        public GameObject BulletGameObject;
        public GameObject NukeBulletGameObject;
        public GameObject BulletShieldGameObject;

        [UsedImplicitly]
        private void Update()
        {
            if (Input.GetButtonDown("Fire1") || AutoFire) Fire(BulletGameObject);

            // ReSharper disable once CompareOfFloatsByEqualityOperator
            if(Input.GetKeyDown(KeyCode.X) && DataHolder.NukeCharge >= 1f)
            {
                DataHolder.NukeCharge = 0f;
                Fire(NukeBulletGameObject);
            }

            // ReSharper disable once CompareOfFloatsByEqualityOperator
            if (Input.GetKeyDown(KeyCode.Z) && DataHolder.ShieldCharge >= 1f)
            {
                DataHolder.ShieldCharge = 0f;
                Fire(BulletShieldGameObject);
            }
        }

        public void Fire(GameObject bullet)
        {
            GameObject bulletInstantiate = Instantiate(bullet);
            bulletInstantiate.transform.position = gameObject.transform.position;
            bulletInstantiate.transform.rotation = gameObject.transform.rotation;
            bulletInstantiate.GetComponent<Bullet>().DataHolder = DataHolder;
        }
    }
}