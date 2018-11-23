#region Usings

using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

#endregion

namespace Assets.Scripts
{
    public class DataHolder : MonoBehaviour
    {
        private float _cleanTimer;
        public List<GameObject> EnemyGameObjects;

        public float NukeCharge = 0f;
        public float ShieldCharge = 0f;
        public float NukeChargeAdd = 0.01f;
        public float ShieldChargeAdd = 0.05f;

        [UsedImplicitly]
        private void Update()
        {
            for (int i = EnemyGameObjects.Count - 1; i >= 0; i--)
            {
                GameObject o = EnemyGameObjects[i];
                if (o == null)
                    // ReSharper disable once ExpressionIsAlwaysNull
                    EnemyGameObjects.Remove(o);
            }
        }
    }
}