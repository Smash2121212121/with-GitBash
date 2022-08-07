using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] ParticleSystem system;
  Rigidbody  rb;
   float mainThrust = 475f;
  

    // Start is called before the first frame update
    void Start()
    {
     rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }
    void ProcessThrust()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.up * mainThrust);

            if (!system.isPlaying)
            {
                system.Play();
            }
        }
        
        else
        {
            system.Stop();
        }
          }
        void ProcessRotation()
        {
        if (Input.GetKey(KeyCode.A))
        {
          transform.Rotate(0, 0, 1.1f);
        }
        if (Input.GetKey(KeyCode.D))
        {
          transform.Rotate(0, 0, -1.1f);
        }
        
    }
}
