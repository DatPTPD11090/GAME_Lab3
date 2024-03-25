using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XController : MonoBehaviour
{
    public float rotationSpeed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion deltaRolation = Quaternion.Euler(0, 0, rotationSpeed * Time.deltaTime);
        transform.rotation = transform.rotation * deltaRolation;
        
    }
}