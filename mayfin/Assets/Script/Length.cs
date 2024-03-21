using UnityEngine;
using UnityEngine.SceneManagement; 

public class MovementRecorder : MonoBehaviour
{
    private Vector3 previousPosition;
    private float totalDistanceMoved = 0f;
    public float restartThreshold = 10f; 

    void Start()
    {
        previousPosition = transform.position;
    }

    void Update()
    {
        float distanceMoved = Vector3.Distance(transform.position, previousPosition);
        totalDistanceMoved += distanceMoved;

        if (totalDistanceMoved > restartThreshold)
        {
            totalDistanceMoved = 0;

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        previousPosition = transform.position;
    }
}
