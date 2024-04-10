using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellorX : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public float rotationSpeed = 500f; 
    
    void Update()
    {
        transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
    }
}
