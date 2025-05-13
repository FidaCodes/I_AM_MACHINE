/*using UnityEngine;
using UnityEngine.UI;


public class KeycardPickup : MonoBehaviour
{
    public string pickupMessage = "Keycard Obtained";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerInventory inventory = other.GetComponent<PlayerInventory>();
            if (inventory != null)
            {
                inventory.hasKeycard = true;
                UIManager.Instance.ShowMessage(pickupMessage);
                Destroy(gameObject);
            }
        }
    }
}
*/