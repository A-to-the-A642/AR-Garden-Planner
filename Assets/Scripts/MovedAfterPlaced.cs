using UnityEngine;

public class MoveAfterPlaced : MonoBehaviour
{
    private Touch touch;
    private float speedModifier = 0.0005f;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                // Move object relative to finger
                transform.position += new Vector3(
                    touch.deltaPosition.x * speedModifier,
                    0,
                    touch.deltaPosition.y * speedModifier
                );
            }
        }
    }
}
