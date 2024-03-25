using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Circle3Controller2 : MonoBehaviour
{
    private int direction = 1;
    private float moveSpeed = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(0f,direction,0f);
        transform.Translate(movement*moveSpeed *Time.deltaTime);
        if(transform.position.y > 2.1f || transform.position.y < -2.25f)
        {
            direction *= -1;
        }
        
    }
}