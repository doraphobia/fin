using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectDetectionSceneLoader : MonoBehaviour
{
    public string objectTag = "EditorOnly"; 

    void Start()
    {
        GameObject targetObject = GameObject.FindGameObjectWithTag(objectTag);

        if (targetObject == null)
        {
            Debug.Log("j");
            LoadNextScene();
        }
    }

    void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        SceneManager.LoadScene(currentSceneIndex + 1);
       
    }
}
