using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 500f;
    Animator animControl;
    // Start is called before the first frame update

    void Start()
    {
        animControl = GetComponent<Animator>();
        animControl.SetBool("Backward", false);
        animControl.SetBool("Forward", false);
    }

    // Update is called once per frame
    void Update()
    {
    // Move & Animation
        if (Input.GetKey(KeyCode.W))
        {
            animControl.SetBool("Forward", true);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            animControl.SetBool("Forward", false);
        }
        if (Input.GetKey(KeyCode.S))
        {
            animControl.SetBool("Backward", true);
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            animControl.SetBool("Backward", false);
        }

    // Turn
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * -rotationSpeed);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.down * Time.deltaTime * -rotationSpeed);
        }

    }
}
