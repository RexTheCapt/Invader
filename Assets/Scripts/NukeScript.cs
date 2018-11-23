#region Usings

using JetBrains.Annotations;
using UnityEngine;

#endregion

namespace Assets.Scripts
{
    public class NukeScript : MonoBehaviour
    {
        public float ExpansionSpeed = 5f;

        [UsedImplicitly]
        void Update()
        {
            float expandBy = Time.deltaTime * ExpansionSpeed;
            Vector3 expandVector3 = new Vector3(expandBy, expandBy, expandBy);

            transform.localScale += expandVector3;

            if(transform.localScale.z > 100)
                Destroy(gameObject);
        }

        [UsedImplicitly]
        // ReSharper disable once ParameterHidesMember
        void OnTriggerEnter(Collider collider)
        {
            if (collider.gameObject.tag == "Enemy")
            {
                Destroy(collider.gameObject);
            }
        }
    }
}