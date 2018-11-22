﻿#region Usings

using JetBrains.Annotations;
using UnityEngine;

#endregion

namespace Assets.Scripts
{
    public class PlayerHealthSystem : MonoBehaviour
    {
        public int Health = 10;

        [UsedImplicitly]
        private void OnTriggerEnter(Collider collision)
        {
            if (collision.gameObject.tag == "Enemy")
            {
                Health--;
                Destroy(collision.gameObject);
            }
        }
    }
}