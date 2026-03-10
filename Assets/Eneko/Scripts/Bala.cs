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
        AddBalaToPool(5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AddBalaToPool(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            GameObject Bala = Instantiate(bala);
            Bala.SetActive(false);
            poolBalas.Add(Bala);
        }
    }

    void Disparar()
    {
        // Buscar uno inactivo en el pool
        GameObject Bala = poolBalas.Find(e => !e.activeSelf);

        // Si no hay, expandir el pool
        if (Bala == null)
        {
            AddBalaToPool(1);
            Bala = poolBalas[poolBalas.Count - 1];
        }

        Bala.transform.position = this.transform.position;
        Bala.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        this.gameObject.SetActive(false);
    }
}
