using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneStick3DController : MonoBehaviour
{
    [SerializeField] float walkSpeed, turnSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(Input.GetAxis("Horizontal")) > 0)
        {
            transform.Rotate(Vector3.up, turnSpeed*Input.GetAxis("Horizontal") * Time.deltaTime);
        }
        if (Mathf.Abs(Input.GetAxis("Vertical")) > 0)
        {
            transform.position+=transform.forward* Input.GetAxis("Vertical") * walkSpeed* Time.deltaTime; 
        }

    }
}
