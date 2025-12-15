using UnityEngine;

public class TargetVisibility : MonoBehaviour
{
    public GameObject[] plants;

    public void ShowPlants()
    {
        foreach (var p in plants)
            p.SetActive(true);
    }

    public void HidePlants()
    {
        foreach (var p in plants)
            p.SetActive(false);
    }
}
