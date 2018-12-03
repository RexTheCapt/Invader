#region Usings

using Assets.Scripts.Components;
using JetBrains.Annotations;
using UnityEngine;
// ReSharper disable MemberCanBePrivate.Global

#endregion

namespace Assets.Scripts
{
    public class SpawnEnemy : MonoBehaviour
    {
        public bool AutoSpawn = false;
        public bool SpawnWithKey = false;
        public KeyCode SpawnEnemyKeyCode = KeyCode.Space;
        public ArenaController DataHolder;
        public GameObject EnemyGameObject;
        public int Quantity = 1;

        private RandomCircle _rc;

        [UsedImplicitly]
        private void Start()
        {
            _rc = gameObject.GetComponent<RandomCircle>();
        }

        [UsedImplicitly]
        private void Update()
        {
            if (Input.GetKey(SpawnEnemyKeyCode) && SpawnWithKey)
                for (int i = 0; i < Quantity; i++)
                {
                    Spawn();
                }

            if(DataHolder.EnemyGameObjects.Count < 10 && (!SpawnWithKey || AutoSpawn))
                Spawn();
        }

        private void Spawn()
        {
            GameObject enemyInstantiate = Instantiate(EnemyGameObject);
            enemyInstantiate.gameObject.GetComponent<Enemy>().PlayerGameObject = gameObject;
            enemyInstantiate.transform.position = _rc.GetVector3(gameObject.transform.position, 50f);
            enemyInstantiate.GetComponent<Enemy>().DataHolder = DataHolder;
        }
    }
}