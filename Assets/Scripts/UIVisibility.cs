using UnityEngine;

public class UIVisibility : MonoBehaviour
{
    public GameObject plantBar;

    public void ShowUI()
    {
        plantBar.SetActive(true);
    }

    public void HideUI()
    {
        plantBar.SetActive(false);
    }
}
