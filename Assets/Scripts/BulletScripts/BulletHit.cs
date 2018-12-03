using JetBrains.Annotations;
using UnityEngine;

namespace Assets.Scripts.BulletScripts
{
    public class BulletHit : MonoBehaviour
    {
        public Bullet Bullet;

        [UsedImplicitly]
        public void OnCollisionEnter(Collision collision)
        {
            ObjectHit(collision.gameObject);
        }

        private void ObjectHit(GameObject game)
        {
            if (game.tag == "Enemy")
            {
                Destroy(game);
                Bullet.DataHolder.EnemyKilled();
                Destroy(gameObject);
            }
        }

        [UsedImplicitly]
        public void OnTriggerEnter(Collider coll)
        {
            ObjectHit(coll.gameObject);
        }
    }
}
