#region Usings

using JetBrains.Annotations;
using UnityEngine;
// ReSharper disable MemberCanBePrivate.Global

#endregion

namespace Assets.Scripts.PlayerScripts
{
    [UsedImplicitly]
    public class PlayerRotate : MonoBehaviour
    {
        public float Sensitivity = 1f;
        public float SpinSpeed = 0f;

        public void Update()
        {
            Cursor.lockState = CursorLockMode.Locked;

            Vector3 rotationVector3 = new Vector3(0, Input.GetAxis("Mouse X") * Sensitivity + SpinSpeed, 0) +
                                      gameObject.transform.rotation.eulerAngles;

            gameObject.transform.rotation = Quaternion.Euler(rotationVector3);
        }
    }
}