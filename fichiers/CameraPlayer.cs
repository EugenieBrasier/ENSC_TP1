using UnityEngine;

public class CameraPlayer : MonoBehaviour
{

    public GameObject player;
    public float distance = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(player == null)
        {
            Debug.LogWarning("The Camera Player is empty, Camera is fixed.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(player != null)
        {
            float x = player.transform.position.x;
            float y = distance;
            float z = player.transform.position.z - distance / 3.5f;

            gameObject.transform.position = new Vector3(x, y, z);
        }
    }
}
