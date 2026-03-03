using UnityEngine;

public class Lever : MonoBehaviour, IInteractable
{
    public Door door;
    bool activated = false;

    public void Interact()
    {
        if (activated) return;

        activated = true;
        door.Open();
    }
}