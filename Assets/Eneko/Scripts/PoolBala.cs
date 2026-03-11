using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class PoolBala : MonoBehaviour
{
    public GameObject bala;
    public List<GameObject> poolBalas;
    public Rigidbody rb;
    private float fuerza = 20f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = bala.GetComponent<Rigidbody>();
        AddBalaToPool(5);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Disparar();
            rb.linearVelocity = Vector3.zero; // Reiniciar la velocidad para evitar acumulación
        }
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
        Bala.transform.rotation = this.transform.rotation;
        Bala.SetActive(true);
        Bala.GetComponent<Rigidbody>().AddForce(transform.forward * fuerza, ForceMode.Impulse);
    }

}
