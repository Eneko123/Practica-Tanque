using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class Bala : MonoBehaviour
{
    public Rigidbody rb;
    public float liveTime = 3f; // Tiempo de vida de la bala en segundos
    public float liveTimeMax = 3f; // Tiempo de vida de la bala en segundos


    void Start()
    {
            rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Life();
    }

    void Shoot()
    {         
        rb.AddForce(transform.forward * 100f, ForceMode.Impulse);
    }

    void Life()
    {
        liveTime -= Time.deltaTime;
        if (liveTime <= 0)
        {
            this.gameObject.SetActive(false);
            this.GetComponent<Rigidbody>().linearVelocity = Vector3.zero; // Reiniciar la velocidad para evitar acumulacion
            liveTime = liveTimeMax; // Reiniciar el tiempo de vida para la proxima vez que se active
        }
    }
}
