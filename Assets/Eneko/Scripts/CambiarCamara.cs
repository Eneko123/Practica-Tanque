using UnityEngine;

public class CambiarCamara : MonoBehaviour
{
    public Camera primeraPersona;
    public Camera terceraPersona;
    public bool camaraPrimeraPersona = true;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (camaraPrimeraPersona)
            {
                primeraPersona.enabled = false;
                terceraPersona.enabled = true;
                camaraPrimeraPersona = false;
            }
            else
            {
                primeraPersona.enabled = true;
                terceraPersona.enabled = false;
                camaraPrimeraPersona = true;
            }
        }
    }
}