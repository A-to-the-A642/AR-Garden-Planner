using UnityEngine;

public class PlantPlacer : MonoBehaviour
{
    public GameObject[] plantPrefabs;
    public Transform plantsRoot;

    private GameObject currentPlant;

    void Update()
    {
        if (currentPlant == null)
            return;

        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag("Ground"))
                {
                    currentPlant.transform.position = hit.point;
                }
            }
        }

        // Rotate with two fingers or Q/E (editor)
        if (Input.GetKey(KeyCode.Q))
            currentPlant.transform.Rotate(Vector3.up, -60f * Time.deltaTime);

        if (Input.GetKey(KeyCode.E))
            currentPlant.transform.Rotate(Vector3.up, 60f * Time.deltaTime);
    }

    // Called by UI buttons
    public void SpawnPlant(int index)
    {
        if (currentPlant != null)
            Destroy(currentPlant);

        currentPlant = Instantiate(
            plantPrefabs[index],
            plantsRoot.position,
            Quaternion.identity,
            plantsRoot
        );

        currentPlant.SetActive(true);
    }
}
