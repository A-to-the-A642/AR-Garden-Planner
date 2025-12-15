using UnityEngine;

public class PlantSelector : MonoBehaviour
{
    public GameObject[] plants;

    void Start()
    {
        ShowPlant(0);
    }

    public void ShowPlant(int index)
    {
        for (int i = 0; i < plants.Length; i++)
        {
            plants[i].SetActive(i == index);
        }
    }
}
