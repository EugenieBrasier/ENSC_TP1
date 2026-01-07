using UnityEngine;

public class Collectible : MonoBehaviour
{
    // The initial number of collectibles
    public static int nb_collectibles = 0;
    
    // The number of collectibles picked up
    public static int nb_collectibles_picked = 0;

    // The rotation speed to the collectibles
    public float speed = 0.5f;

    void Start()
    {
        // Each collectible increase the total number of collectibles 
        // by 1
        nb_collectibles ++;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 angles = transform.eulerAngles;
        angles.x = 33.33f;
        angles.y += speed;
        angles.z = 45f;
        transform.eulerAngles = angles;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Ball")
        {
            // When picked up, each collectible increase the total 
            // number of collectibles picked up by 1
            nb_collectibles_picked++;

            // We print the winning message
            gameObject.SetActive(false);
            if(nb_collectibles == nb_collectibles_picked)
            {
                Debug.Log("You won");
            }
        }
    }
}
