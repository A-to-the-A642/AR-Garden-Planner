using UnityEngine;

public class ScanHintUI : MonoBehaviour
{
    public GameObject scanText;

    public void OnTargetFound()
    {
        scanText.SetActive(false);
    }

    public void OnTargetLost()
    {
        scanText.SetActive(true);
    }
}
