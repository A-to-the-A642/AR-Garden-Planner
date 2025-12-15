using UnityEngine;
using Vuforia;

public class PlantActivator : MonoBehaviour
{
    public GameObject[] plants;

    private DefaultObserverEventHandler observer;

    void Awake()
    {
        observer = GetComponent<DefaultObserverEventHandler>();
        observer.OnTargetFound.AddListener(TargetFound);
        observer.OnTargetLost.AddListener(TargetLost);
    }

    void TargetFound()
    {
        foreach (GameObject plant in plants)
            plant.SetActive(true);
    }

    void TargetLost()
    {
        foreach (GameObject plant in plants)
            plant.SetActive(false);
    }
}
