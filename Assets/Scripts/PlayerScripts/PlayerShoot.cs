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
        [UsedImplicitly] public ArenaController DataHolder;
        [UsedImplicitly] public GameObject BulletGameObject;
        [UsedImplicitly] public GameObject NukeBulletGameObject;

        [UsedImplicitly]
        private void Update()
        {
            if (Input.GetButtonDown("Fire1") || AutoFire) Fire(BulletGameObject);

            // ReSharper disable once CompareOfFloatsByEqualityOperator
            if(Input.GetKeyDown(KeyCode.X) && DataHolder.NukeCharge >= 1f)
            {
                DataHolder.ActivateNuke();
                Fire(NukeBulletGameObject);
            }

            // ReSharper disable once CompareOfFloatsByEqualityOperator
            if (Input.GetKeyDown(KeyCode.Z) && DataHolder.ShieldCharge >= 1f)
            {
                DataHolder.ActivateShield();
            }
        }

        public void Fire(GameObject bullet)
        {
            GameObject bulletInstantiate = Instantiate(bullet);
            bulletInstantiate.transform.position = gameObject.transform.position;
            bulletInstantiate.transform.rotation = gameObject.transform.rotation;
            try
            {
                bulletInstantiate.GetComponent<Bullet>().DataHolder = DataHolder;
            }
            catch
            {
                // ignored
            }
        }
    }
}