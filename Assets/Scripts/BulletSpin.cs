#region Usings

using JetBrains.Annotations;
using UnityEngine;

#endregion

namespace Assets.Scripts
{
    public class BulletSpin : MonoBehaviour
    {
        public float SpinSpeed = 1f;

        [UsedImplicitly]
        private void Update()
        {
            Vector3 rotationVector3 = new Vector3(0, SpinSpeed, 0) + gameObject.transform.rotation.eulerAngles;

            gameObject.transform.rotation = Quaternion.Euler(rotationVector3);
        }
    }
}