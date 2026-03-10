using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public float speed = 8f;
    private Vector2 direction;

    public void SetTarget(Transform player)
    {
        direction = (player.position - transform.position).normalized;
        transform.up = direction;
    }

    void Update()
    {
        transform.position += (Vector3)(direction * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager gm = Object.FindFirstObjectByType<GameManager>();

            if (gm != null)
                gm.GameOver();

            Destroy(other.gameObject);
            Destroy(gameObject);
        }

        if (!other.isTrigger)
        {
            Destroy(gameObject);
        }
    }
}