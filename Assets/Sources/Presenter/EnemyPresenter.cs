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
        else if (collision.gameObject.CompareTag("NloArmy"))
        {
            DestroyCompose();
        }
    }
}
}