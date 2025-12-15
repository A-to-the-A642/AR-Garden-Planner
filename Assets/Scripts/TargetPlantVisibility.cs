using UnityEngine;

public class TargetPlantVisibility : MonoBehaviour
{
    public Transform plantsRoot;

    public void OnTargetLost()
    {
        plantsRoot.gameObject.SetActive(false);
    }

    public void OnTargetFound()
    {
        plantsRoot.gameObject.SetActive(true);
    }
}
