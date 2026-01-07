using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections;


public class SceneManager : MonoBehaviour
{
    // The total number of collectibles in the scene
    public int nb_collectibles = 8;

    // The radius of the circle on which we will place 
    // the collectible objects
    public float radius = 0.4f;

    // The field prefab
    public GameObject field_prefab;

    // The ball prefab
    public GameObject ball_prefab;

    // The collectible prefab
    public GameObject collectible_prefab;

    // The text where we show the number of collectibles 
    // that have already been picked up
    public TextMeshProUGUI countUI; 

    // The text to show when the game is won
    public TextMeshProUGUI finalUI; 

    void Start()
    {

        // We reset the number of collectible
        Collectible.nb_collectibles = 0;
        Collectible.nb_collectibles_picked = 0;

        // We reset the interface
        finalUI.gameObject.SetActive(false);
        countUI.gameObject.SetActive(true);

        // We create the field
        Instantiate(field_prefab, new Vector3(0f, 0f, 0f), Quaternion.identity);

        // We create the ball
        GameObject ball = Instantiate(ball_prefab, new Vector3(0f, 0.05f, 0f), Quaternion.identity);
        ball.name = "Ball";
        Camera.main.GetComponent<CameraPlayer>().player = ball;

        // We create the collectibles
        for (int i = 0; i < nb_collectibles; i++)
        {
            float angle = i * Mathf.PI * 2f / nb_collectibles;

            float x = Mathf.Cos(angle) * radius;
            float z = Mathf.Sin(angle) * radius;

            Vector3 position = new Vector3(x, 0.05f, z);
            Instantiate(collectible_prefab, position, Quaternion.identity);
        }
        

    }

    void Update()
    {
        // We show the number of collectibles picked up
        countUI.text = "Objects Colected: " + Collectible.nb_collectibles_picked + "/" + Collectible.nb_collectibles;

        // If all the collectibles have been picked up
        if(Collectible.nb_collectibles != 0 && Collectible.nb_collectibles == Collectible.nb_collectibles_picked)
        {
            finalUI.gameObject.SetActive(true);
            countUI.gameObject.SetActive(false);

            // We start a Coroutine which reload the scene after 5 seconds
            StartCoroutine(ReloadSceneCoroutine());
        }
    }

    IEnumerator ReloadSceneCoroutine()
    {
        // We wait for 5 seconds
        yield return new WaitForSeconds(5);

        // We reload the scene
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
    }
}
