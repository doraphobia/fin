using UnityEngine;
using System.Collections;

public class MaterialChanger : MonoBehaviour
{
    public Material[] materialsToSwitchTo;
    public float delayBetweenChanges = 1f; 

    private Renderer objectRenderer;

    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        StartCoroutine(ChangeMaterials());
    }

    IEnumerator ChangeMaterials()
    {
        foreach (Material mat in materialsToSwitchTo)
        {
            objectRenderer.material = mat;
            yield return new WaitForSeconds(delayBetweenChanges);
        }
    }
}
