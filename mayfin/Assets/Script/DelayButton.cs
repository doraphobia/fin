using UnityEngine;
using UnityEngine.UI; 
using System.Collections; 

public class DelayedButton : MonoBehaviour
{
    public Button button; 
    public float delay = 2f; 

    void Start()
    {
        if (button == null)
        {
            button = GetComponent<Button>();
        }

        StartCoroutine(DelayButtonInteraction());
    }

    IEnumerator DelayButtonInteraction()
    {
        button.interactable = false;

        yield return new WaitForSeconds(delay);

        button.interactable = true;

    }
}
