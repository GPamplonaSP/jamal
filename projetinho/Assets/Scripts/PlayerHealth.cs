using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int life = 5;

    public void Heal(int amount)
    {
        life += amount;
    }
}