
using UnityEngine;

public class PLAYERMOVEMENT : MonoBehaviour
{
    public Rigidbody rb;
    public float ForwardForce = 2000f;
    public float SidewaysForce = 500f;


    
    void Start()
    {
        //rb.AddForce(0, 500, 200);
        //rb.useGravity = false;

    }
        
 void FixedUpdate()
      {
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);
        if(Input.GetKey("d"))
        {
            rb.AddForce(SidewaysForce * Time.deltaTime, 0, 0 , ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(- SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
