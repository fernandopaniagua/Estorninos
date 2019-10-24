using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Spawns starlings in a radius
/// </summary>
public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject prefabStarling;
    [SerializeField] int numberOfStarlings;
    [SerializeField] int radius;
    private Vector3 position;
    void Start()
    {
        for(int i = 0; i < numberOfStarlings; i++)
        {
            position = new Vector3(
                Random.Range(transform.position.x - radius, transform.position.x + radius),
                Random.Range(transform.position.y - radius, transform.position.y + radius),
                Random.Range(transform.position.z - radius, transform.position.z + radius));
            Instantiate(prefabStarling, position, Quaternion.identity);
        }            
    }

    
}
