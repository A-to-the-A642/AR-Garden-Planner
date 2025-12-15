using UnityEngine;

public class OnPlacedActions : MonoBehaviour
{
    public void WasPlaced()
    {
        //rotate
        transform.Rotate(0, Random.Range(0, 360f), 0);

        Debug.Log($"{gameObject.name} was placed!");
    }
}
