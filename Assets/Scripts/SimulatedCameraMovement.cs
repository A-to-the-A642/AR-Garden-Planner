using UnityEngine;

public class SimulatedCameraMovement : MonoBehaviour
{
    public float speed = 3f;
    public float rotationSpeed = 120f;

    void Update()
    {
        // allows camera to move up and down like fps
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(h, 0, v) * speed * Time.deltaTime);

        // allows mouse movement
        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
        transform.Rotate(0, mouseX, 0);
    }
}
