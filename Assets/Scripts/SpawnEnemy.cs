#region Usings

using Assets.Scripts.Components;
using JetBrains.Annotations;
using UnityEngine;

#endregion

namespace Assets.Scripts
{
    public class SpawnEnemy : MonoBehaviour
    {
        public bool AutoSpawn = false;
        public DataHolder DataHolder;
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
            if (Input.GetKey(KeyCode.Space) || AutoSpawn)
                for (int i = 0; i < Quantity; i++)
                {
                    GameObject enemyInstantiate = Instantiate(EnemyGameObject);
                    enemyInstantiate.gameObject.GetComponent<Enemy>().PlayerGameObject = gameObject;
                    enemyInstantiate.transform.position = _rc.GetVector3(gameObject.transform.position, 50f);
                    enemyInstantiate.GetComponent<Enemy>().DataHolder = DataHolder;
                }
        }
    }
}