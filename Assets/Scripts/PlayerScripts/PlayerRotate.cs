#region Usings

using UnityEngine;
// ReSharper disable MemberCanBePrivate.Global

#endregion

namespace Assets.Scripts.PlayerScripts
{
    public class PlayerRotate : MonoBehaviour
    {
        public float Senstivity = 1f;
        public float SpinSpeed = 0f;

        public void Update()
        {
            Cursor.lockState = CursorLockMode.Locked;

            Vector3 rotationVector3 = new Vector3(0, Input.GetAxis("Mouse X") * Senstivity + SpinSpeed, 0) +
                                      gameObject.transform.rotation.eulerAngles;

            gameObject.transform.rotation = Quaternion.Euler(rotationVector3);
        }
    }
}