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