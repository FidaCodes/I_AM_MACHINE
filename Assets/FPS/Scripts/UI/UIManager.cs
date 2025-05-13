using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    public Text pickupMessageText;
    public float messageDuration = 2f;

    private void Awake()
    {
        Instance = this;
    }

    public void ShowMessage(string message)
    {
        StopAllCoroutines();
        StartCoroutine(ShowMessageRoutine(message));
    }

    private IEnumerator ShowMessageRoutine(string message)
    {
        pickupMessageText.text = message;
        pickupMessageText.gameObject.SetActive(true);
        yield return new WaitForSeconds(messageDuration);
        pickupMessageText.gameObject.SetActive(false);
    }
}
