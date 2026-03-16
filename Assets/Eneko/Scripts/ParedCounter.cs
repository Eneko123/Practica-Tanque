using TMPro;
using UnityEngine;

public class ParedCounter : MonoBehaviour
{
    public Canvas canvas;
    public GameObject victoria;
    public GameObject counter;
    public GameObject[] paredes;

    public int contadorParedes = 0;
    private bool juegoTerminado = false;

    void Start()
    {
        victoria.SetActive(false);

        ActualizarContador();
    }

    void Update()
    {
        if (!juegoTerminado && contadorParedes >= paredes.Length)
        {
            MostrarVictoria();
        }
    }

    public void ParedDestruida()
    {
        contadorParedes++;
        ActualizarContador();
    }

    private void ActualizarContador()
    {
        counter.GetComponent<TMP_Text>().text = contadorParedes + " / " + paredes.Length;
    }

    private void MostrarVictoria()
    {
        juegoTerminado = true;
        victoria.SetActive(true);
        Debug.Log("¡Todas las paredes han sido destruidas!");
    }
}