using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections; 

public class RandomLevelLoader : MonoBehaviour
{
    public string[] levels; 

    public void StartLoadRandomLevel()
    {
        StartCoroutine(LoadRandomLevelWithDelay(1.5f)); 
    }

    IEnumerator LoadRandomLevelWithDelay(float delay)
    {
        if (levels.Length == 0)
        {
            Debug.LogError("No levels to load!");
            yield break; 
        }

        yield return new WaitForSeconds(delay);

        int randomIndex = Random.Range(0, levels.Length);

        SceneManager.LoadScene(levels[randomIndex]);
    }
}
