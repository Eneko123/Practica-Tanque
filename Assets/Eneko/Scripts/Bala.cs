using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class Bala : MonoBehaviour
{
    public GameObject bala;
    public List<GameObject> poolBalas;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 5; i++)
        { 
            if (poolBalas[i] == null)
            {
                Instantiate(bala);
                bala.SetActive(false);
                poolBalas.Add(poolBalas[i]);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        this.gameObject.SetActive(false);
    }
}
