using UnityEngine;
using UnityEngine.UI; 

public class SpinButtonImage : MonoBehaviour
{
    public Button button; 
    public float spinSpeed = 360f; 
    public float spinDuration = 0.5f; 

    private bool isSpinning = false;
    private float spinTimeRemaining;

    void Update()
    {
        if (isSpinning)
        {
            SpinImage();
        }
    }

    public void StartSpin()
    {
        if (!isSpinning) 
        {
            isSpinning = true;
            spinTimeRemaining = spinDuration;
        }
    }

    private void SpinImage()
    {
        float spinAmount = spinSpeed * Time.deltaTime;
        spinTimeRemaining -= Time.deltaTime;

        button.image.transform.Rotate(0, 0, spinAmount);

        if (spinTimeRemaining <= 0)
        {
            isSpinning = false;
      
        }
    }
}
