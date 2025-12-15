using UnityEngine;
using UnityEngine.SceneManagement; // Needed to load scenes

public class ARSceneUI : MonoBehaviour
{
    // This function will be called when Back button is pressed
    public void GoBackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu"); // Replace with your exact scene name
    }
}
