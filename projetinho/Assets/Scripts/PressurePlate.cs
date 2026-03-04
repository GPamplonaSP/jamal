using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public Door door;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            door.Open();
        }
    }
}