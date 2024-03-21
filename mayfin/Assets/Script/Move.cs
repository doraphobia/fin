using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateMovement : MonoBehaviour
{
    public ParticleSystem dust;
    public float speed = 5f; 
    private Vector2 movementDirection = Vector2.up;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();

    }

    public void PlayerMovement()
    {
        Vector2 inputDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        if (inputDirection != Vector2.zero)
        {
            movementDirection = inputDirection.normalized; 
        }

        transform.Translate(movementDirection * speed * Time.deltaTime);


    }

}
