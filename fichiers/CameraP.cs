using UnityEngine;

public class CameraP : MonoBehaviour
{

    public GameObject ball;

    private float x;
    private float y;
    private float z;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float x_ball = ball.transform.position.x;
        float y_ball = ball.transform.position.y;
        float z_ball = ball.transform.position.z;

        float x_camera = gameObject.transform.position.x;
        float y_camera = gameObject.transform.position.y;
        float z_camera = gameObject.transform.position.z;

        x = x_ball - x_camera;
        y = y_ball - y_camera;
        z = z_ball - z_camera;
    }

    // Update is called once per frame
    void Update()
    {
        float x_ball = ball.transform.position.x;
        float y_ball = ball.transform.position.y;
        float z_ball = ball.transform.position.z;

        gameObject.transform.position = new Vector3(x_ball - x, y_ball - y, z_ball - z);
    }
}
