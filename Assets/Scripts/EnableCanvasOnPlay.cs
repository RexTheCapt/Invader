﻿#region Usings

using JetBrains.Annotations;
using UnityEngine;

#endregion

namespace Assets.Scripts
{
    public class EnableCanvasOnPlay : MonoBehaviour
    {
        public GameObject CanvasGameObject;

        // Use this for initialization
        [UsedImplicitly]
        private void Start()
        {
            CanvasGameObject.SetActive(true);
        }
    }
}