using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float HSpeed = 7.0f;
    public float VForce = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        CharacterMovement();
      
    }
    void CharacterMovement() 
    {
        float HInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(HInput, 0, 0) * Time.deltaTime * HSpeed);

        if(Input.GetKeyUp(KeyCode.Space))
        {
            transform.Translate(new Vector3(0, VForce, 0) * Time.deltaTime * VForce);
        }
    }
}
