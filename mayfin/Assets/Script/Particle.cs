using UnityEngine;

public class CollisionParticles : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<ParticleSystem>().Play();
        //GetComponent<SpriteRenderer>().enabled = false;
    }

}
