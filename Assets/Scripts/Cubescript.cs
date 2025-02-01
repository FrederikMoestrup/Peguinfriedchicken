using System;
using UnityEngine;

public class Cubescript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    //[SerializeField] private Rigidbody rigidbody;
    private Rigidbody rigidbody;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        
        Debug.Log("Hello World!");
    }


    private void OnCollisionEnter(Collision col)
    {
        Debug.Log("Collision detected with " + col.gameObject.name);
        rigidbody.AddForce(Vector3.up * 1000);
    }
}
