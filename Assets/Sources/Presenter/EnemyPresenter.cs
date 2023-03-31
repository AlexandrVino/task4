using UnityEngine;

namespace Asteroids.Model
{
    public class EnemyPresenter : Presenter
    {
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Bullet"))
            {
                DestroyCompose();
            }
            else if (gameObject.CompareTag("NloArmyRed") && collision.gameObject.CompareTag("NloArmyGreen"))
            {
                DestroyCompose();
            }
            else if (gameObject.CompareTag("NloArmyGreen") && collision.gameObject.CompareTag("NloArmyRed"))
            {
                DestroyCompose();
            }
        }
    }
}