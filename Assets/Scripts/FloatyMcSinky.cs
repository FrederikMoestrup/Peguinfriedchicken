using System;
using UnityEngine;

public class FloatyMcSinky : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    private Rigidbody rigidbody;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        
        Debug.Log("Hello World!");
        
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.AddForce(Vector3.up * 1000);
        }
        rigidbody.rotation = Quaternion.identity;
    }
    
    private void OnCollisionEnter(Collision col)
    {
        Debug.Log("Collision detected with " + col.gameObject.name);
        rigidbody.AddForce(Vector3.up * 1000);
    }
}