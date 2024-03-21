using UnityEngine;

public class ShowCanvasOnTrigger : MonoBehaviour
{
    public Canvas canvasToShow; 

    private void Start()
    {
        canvasToShow.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("EditorOnly")) 
        {
            canvasToShow.gameObject.SetActive(true);
        }
    }
}
