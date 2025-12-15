using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScripts : MonoBehaviour
{
    // Call this on the Start button
    public void StartGame()
    {
        SceneManager.LoadScene("ARGardenScene"); // Replace with your AR Garden scene name
    }

    // Call this on the Credits button
    public void OpenCredits()
    {
        SceneManager.LoadScene("CreditsMenu"); // Replace with your Credits scene name
    }

    // Call this on the Quit button
    public void QuitGame()
    {
        Debug.Log("Quit Game"); // Only works in build
        Application.Quit();
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu"); // Replace with the exact name of your Main Menu scene
    }
}
