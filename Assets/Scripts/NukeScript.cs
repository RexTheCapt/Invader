#region Usings

using UnityEngine;

#endregion

namespace Assets.Scripts
{
    public class NukeScript : MonoBehaviour
    {
        public float ExpansionSpeed = 5f;

        void Update()
        {
            float ExpandBy = Time.deltaTime * ExpansionSpeed;
            Vector3 expandVector3 = new Vector3(ExpandBy, ExpandBy, ExpandBy);

            transform.localScale += expandVector3;

            if(transform.localScale.z > 100)
                Destroy(gameObject);
        }

        void OnTriggerEnter(Collider collider)
        {
            if (collider.gameObject.tag == "Enemy")
            {
                Destroy(collider.gameObject);
            }
        }
    }
}