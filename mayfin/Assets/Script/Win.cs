using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections; 

public class CollisionTimer : MonoBehaviour
{
    private float collisionTime;
    private bool isColliding;
    private float cumulativeCollisionTime; 
    public GameObject[] objectsToSpin; 
    public float spinDuration = 1f; 
    public float spinSpeed = 360f; 
    public int scoreValue = 1; 
    public Canvas endGameCanvas; 
    public float timeToShowCanvas = 10f; 

    void Start()
    {

    }

    void Update()
    {
        if (isColliding)
        {
            collisionTime += Time.deltaTime;
            cumulativeCollisionTime += Time.deltaTime; 

            if (collisionTime >= 1f && !IsInvoking("ChangeScene"))
            {
                StartCoroutine(SpinObjects(spinDuration));
            }

            if (cumulativeCollisionTime >= timeToShowCanvas)
            {

            }
        }
    }

    IEnumerator SpinObjects(float duration)
    {
        float elapsedTime = 0;

        while (elapsedTime < duration)
        {
            foreach (GameObject obj in objectsToSpin)
            {
                if (obj != null)
                {
                    obj.transform.Rotate(Vector3.forward, spinSpeed * Time.deltaTime);
                }
            }

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        ChangeScene();
    }

    void ChangeScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isColliding = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isColliding = false;
            collisionTime = 0f;
        }
    }


}
