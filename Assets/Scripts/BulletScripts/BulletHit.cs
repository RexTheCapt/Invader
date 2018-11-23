#region Usings

using JetBrains.Annotations;
using UnityEngine;
// ReSharper disable MemberCanBePrivate.Global

#endregion

namespace Assets.Scripts.BulletScripts
{
    public class BulletHit : MonoBehaviour
    {
        public GameObject ParentGameObject;

        [UsedImplicitly]
        // ReSharper disable once ParameterHidesMember
        private void OnTriggerEnter(Collider collider)
        {
            if (collider.tag == "Enemy")
            {
                Destroy(collider.gameObject);
                ParentGameObject.GetComponent<Bullet>().DestructOnContact();
            }
        }
    }
}