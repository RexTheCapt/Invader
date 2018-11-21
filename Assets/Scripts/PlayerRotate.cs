using UnityEngine;

namespace Assets.Scripts
{
    public class PlayerRotate : MonoBehaviour
    {
        public float Senstivity = 1f;
        public float spinSpeed = 0f;

        public void Update()
        {
            Cursor.lockState = CursorLockMode.Locked;

            Vector3 rotationVector3 = new Vector3(0, Input.GetAxis("Mouse X") * Senstivity + spinSpeed, 0) + gameObject.transform.rotation.eulerAngles;

            gameObject.transform.rotation = Quaternion.Euler(rotationVector3);
        }
    }
}
