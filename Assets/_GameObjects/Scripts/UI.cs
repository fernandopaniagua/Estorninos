using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField] Button startButton;
    [SerializeField] GameObject spawner;
    public void StartSimulation()
    {
        Destroy(startButton.gameObject);
        spawner.SetActive(true);
    }
}
