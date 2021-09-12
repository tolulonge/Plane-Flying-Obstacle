using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropeller : MonoBehaviour
{
    // Start is called before the first frame update
    public float accx;
    public float accy;
    public float accz;
    public float turnSpeed = 30.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 50 * Time.deltaTime * turnSpeed);


    }
}
