using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCharacterController : MonoBehaviour {
    public CharacterController charController;
    public float movementSpeed;
    private Transform playerTransform;

    void Start()
    {
        playerTransform = transform;
    }
    void Update()
    {
        Move();
    }

    private void Move()
    {
        if(Input.GetAxis("Vertical") != 0)
        {
            charController.transform.position += playerTransform.forward * Input.GetAxisRaw("Vertical") * Time.deltaTime * movementSpeed;
        }
        if (Input.GetAxis("Horizontal") != 0)
        {
            charController.transform.position += playerTransform.right * Input.GetAxisRaw("Horizontal") * Time.deltaTime * movementSpeed;
        }
    }
    
}

