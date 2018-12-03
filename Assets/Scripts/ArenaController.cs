#region Usings

using System;
using System.Collections.Generic;
using Assets.Scripts.PlayerScripts;
using JetBrains.Annotations;
using UnityEngine;

#endregion

namespace Assets.Scripts
{
    public class ArenaController : MonoBehaviour
    {
        private float _cleanTimer;
        [UsedImplicitly] public GameObject PlayerGameObject;
        [UsedImplicitly] public List<GameObject> EnemyGameObjects;

        public float NukeCharge
        {
            get { return _nukeCharge; }
        }
        public float ShieldCharge
        {
            get { return _shieldCharge; }
        }
        [UsedImplicitly] public float NukeChargeAdd = 0.01f;
        [UsedImplicitly] public float ShieldChargeAdd = 0.05f;

        [SerializeField]
        private float _nukeCharge;
        [SerializeField]
        private float _shieldCharge;

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

            if (_shieldCharge > 1)
                _shieldCharge = 1;

            if (_nukeCharge > 1)
                _nukeCharge = 1;
        }

        /// <summary>
        /// Used when an enemy is killed.
        /// </summary>
        public void EnemyKilled()
        {
            _nukeCharge += NukeChargeAdd;
            _shieldCharge += ShieldChargeAdd;
        }

        /// <summary>
        /// Used to activate the shield.
        /// </summary>
        public void ActivateShield()
        {
            _shieldCharge = 0;
            throw new NotImplementedException("Shield function not added");
        }

        /// <summary>
        /// Used to activate the nuke.
        /// </summary>
        public void ActivateNuke()
        {
            PlayerShoot playerShoot = PlayerGameObject.GetComponent<PlayerShoot>();
            GameObject nukeGameObject = playerShoot.NukeBulletGameObject;

            if (_nukeCharge >= 1)
            {
                GameObject nuke = Instantiate(nukeGameObject);

                nuke.transform.position = PlayerGameObject.transform.position;

                _nukeCharge = 0;
            }
        }
    }
}