using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    //A Gameobject for the confirmation pop up
    public GameObject QuitDeathScreenConfirmation;
    //displaying the confirmation if the quit button is clicked
    public void Quit()
    {
        QuitDeathScreenConfirmation.SetActive(true);
    }
    //A function for Quitting the game if Yes is clicked
    public void ConfirmQuit() 
    {
        Application.Quit();
        //confirmation message for testing purposes
        Debug.Log("Quit successful");
        //If the exit button is clicked, the unity editor also stops playing the game
        //Unity editor ignores the Application.Quit() and it keeps on playing the game
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }

    //a function for cancelling the quit and go back to the main menu
    public void CancelQuit() 
    {
        QuitDeathScreenConfirmation.SetActive(false);
    }
}
