using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCameraController : MonoBehaviour {
    public Vector2 mouseSensitivity; 
    private Transform camTransform, charTransform;

	// Use this for initialization
	void Start ()
    {
        charTransform = transform;
        camTransform = Camera.main.transform;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetAxisRaw("Mouse X") != 0)
        {
            charTransform.rotation *= Quaternion.AngleAxis(Input.GetAxisRaw("Mouse X") * mouseSensitivity.x, Vector3.up);
        }

        if(Input.GetAxisRaw("Mouse Y") != 0)
        {
            camTransform.rotation *= Quaternion.AngleAxis(Input.GetAxisRaw("Mouse Y") * -mouseSensitivity.y, Vector3.right);
        }

    }
}
