using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] float speed;
    private float x, y;
    
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }
    private void FixedUpdate()
    {
        transform.Translate(new Vector3(x * speed * Time.deltaTime, 0, y * speed * Time.deltaTime));
    }
}
