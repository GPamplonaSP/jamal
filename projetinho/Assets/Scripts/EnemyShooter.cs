using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform firePoint;
    public float shootCooldown = 2f;

    private float timer;
    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            Shoot();
            timer = shootCooldown;
        }
    }

    void Shoot()
    {
        GameObject proj = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);

        proj.GetComponent<EnemyProjectile>().SetTarget(player);
    }
}