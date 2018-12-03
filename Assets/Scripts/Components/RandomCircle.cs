#region Usings

using UnityEngine;

#endregion

namespace Assets.Scripts.Components
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class RandomCircle : MonoBehaviour
    {
        public Vector3 GetVector3(Vector3 center, float radius)
        {
            float ang = Random.value * 360;
            Vector3 pos;
            pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
            pos.z = center.z + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
            pos.y = center.y;
            return pos;
        }
    }
}