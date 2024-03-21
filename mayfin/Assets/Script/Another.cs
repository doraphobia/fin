using UnityEngine;

public class CollisionScoreUpdater : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("EditorOnly"))
        {
            if (ScoreManager.Instance != null)
            {
                ScoreManager.Instance.AddScore(1);
            }
        }
    }
}
