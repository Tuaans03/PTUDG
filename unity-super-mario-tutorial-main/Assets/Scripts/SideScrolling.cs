using UnityEngine;

[RequireComponent(typeof(Camera))]
public class SideScrolling : MonoBehaviour
{
    private new Camera camera;
    private Transform player;

    public float height = 6.5f;
    public float undergroundHeight = -9.5f;
    public float undergroundThreshold = 0f;

    private void Awake()
    {
        camera = GetComponent<Camera>();
        player = GameObject.FindWithTag("Player").transform;
    }

    private void LateUpdate()
    {
        // Track the player moving to the right
        Vector3 cameraPosition = transform.position;
        cameraPosition.x = Mathf.Max(cameraPosition.x, player.position.x);

        // Check if the player is below the underground threshold
        if (player.position.y < undergroundThreshold)
        {
            // Adjust the camera height to the underground height
            cameraPosition.y = undergroundHeight;
        }
        else
        {
            // Keep the camera at the default height
            cameraPosition.y = height;
        }

        // Update the camera position
        transform.position = cameraPosition;
    }

    public void SetUnderground(bool underground)
    {
        // set underground height offset
        Vector3 cameraPosition = transform.position;
        cameraPosition.y = underground ? undergroundHeight : height;
        transform.position = cameraPosition;
    }

}
