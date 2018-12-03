#region Usings

using JetBrains.Annotations;
using UnityEngine;

#endregion

namespace Assets.Scripts
{
    public class Enemy : MonoBehaviour
    {
        public ArenaController DataHolder;
        public GameObject PlayerGameObject;

        // Use this for initialization
        [UsedImplicitly]
        private void Start()
        {
            gameObject.transform.LookAt(PlayerGameObject.transform.position);
            DataHolder.EnemyGameObjects.Add(gameObject);
        }

        // Update is called once per frame
        [UsedImplicitly]
        private void Update()
        {
            transform.position += transform.forward * Time.deltaTime * 5;
        }
    }
}