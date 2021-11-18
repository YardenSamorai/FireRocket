using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField]float thrust = 1000f;
    [SerializeField]float GoLeft = 200f;
    [SerializeField]float GoRight = -200f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotation();

    }


    void ProcessThrust()
    {
       if (Input.GetKey(KeyCode.Space))
       {
            rb.AddRelativeForce((Vector2.up * thrust) * Time.deltaTime);
       }
    }

    void ProcessRotation()
    {
        if (Input.GetKey(KeyCode.D))
       {
           Power(GoRight);
       }
       else if (Input.GetKey(KeyCode.A))
       {
           Power(GoLeft);
       }
    }

    void Power(float Rotate)
    {   
        rb.freezeRotation = true; 
        transform.Rotate((Vector3.forward * Rotate) * Time.deltaTime);
        rb.freezeRotation = false;
    }


}

