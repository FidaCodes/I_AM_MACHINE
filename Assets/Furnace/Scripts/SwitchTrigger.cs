using UnityEngine;

public class SwitchTrigger : MonoBehaviour
{
    public DoorManager doorManager;
    private bool isActivated = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!isActivated && other.CompareTag("Player"))
        {
            isActivated = true;
            doorManager.RegisterSwitchActivated();
            // Optional: Visual feedback
            GetComponent<Renderer>().material.color = Color.green;
        }
    }
}
