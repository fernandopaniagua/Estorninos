using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarlingFollower : MonoBehaviour
{
    [SerializeField] float repeatRate;
    [SerializeField] float minForce;
    [SerializeField] float maxForce;
    private Rigidbody rb;
    private Transform stearlingLeader;
    public Vector3 direction;
    public float distance;
    void Start()
    {
        stearlingLeader = GameObject.Find("StarlingLeader").transform;
        rb = GetComponent<Rigidbody>();
        InvokeRepeating("GetDirection", 0, repeatRate);
    }
    
    private void GetDirection()
    {
        GameObject masRapido = this.gameObject;
        direction = (stearlingLeader.position - this.transform.position);
        rb.AddForce(direction.normalized * Random.Range(minForce, maxForce));
    }

}
