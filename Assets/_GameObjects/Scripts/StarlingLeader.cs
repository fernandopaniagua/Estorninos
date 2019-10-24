using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarlingLeader : MonoBehaviour
{
    [SerializeField] float repeatRate;
    [SerializeField] float minForce;
    [SerializeField] float maxForce;
    private Rigidbody rb;
    public Vector3 direction;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        InvokeRepeating("GetDirection", 0, repeatRate);
    }
    
    private void GetDirection()
    {
        direction = new Vector3(Random.Range(-180f, 180f), Random.Range(-180f, 180f), Random.Range(-180f, 180f));
        transform.rotation = Quaternion.Euler(direction);
        rb.AddForce(transform.forward * Random.Range(minForce, maxForce));
    }
}
