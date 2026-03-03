using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int life = 3;

    public void TakeDamage(int damage)
    {
        life -= damage;

        if (life <= 0)
            Destroy(gameObject);
    }
}