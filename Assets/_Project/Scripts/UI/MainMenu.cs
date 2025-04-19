using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject QuitConfirmationPanel;
    /*
     * a function for the play button in the main menu
     *When the users click on the play button, this function will be called 
     * and it will take them to the next screen
     */
    public void Play() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Called when Quit is clicked
    public void Quit()
    {
        QuitConfirmationPanel.SetActive(true); // Show the confirmation popup
    }

    // Called when the user confirms quitting
    public void ConfirmQuit()
    {
        Application.Quit();
        Debug.Log("Quit functino working fine");

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }

    // Called when the user cancels quitting
    public void CancelQuit()
    {
        QuitConfirmationPanel.SetActive(false); // Hide the popup
    }
}
