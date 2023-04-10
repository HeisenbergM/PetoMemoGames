using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Movement : MonoBehaviour
{
    [SerializeField]float MainThrust = 100f;
    Rigidbody rb;
    [SerializeField]float Rotation = 1000f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotate();
    }
       
       void ProcessThrust()
       {
            if(Input.GetKey("space"))
                {
                   rb.AddRelativeForce(Vector3.up * MainThrust * Time.deltaTime);
                }
       }


        void ProcessRotate()
        {
            if(Input.GetKey("a"))
                {
                    applyRotation(Rotation);
                }
            else if(Input.GetKey("d"))
                {
                    applyRotation(-Rotation);
                }
        }
    void applyRotation(float rotationThisFrame)
    {
        rb.freezeRotation = true;
        transform.Rotate(Vector3.forward * rotationThisFrame * Time.deltaTime);
        rb.freezeRotation = false;
    }


}


