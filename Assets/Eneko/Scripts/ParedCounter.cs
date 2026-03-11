using TMPro;
using UnityEngine;

public class ParedCounter : MonoBehaviour
{
    public Canvas canvas;
    public GameObject victoria;
    public GameObject counter;
    public GameObject[] paredes;
    public int contadorParedes = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        counter.GetComponent<TextMeshPro>().text = contadorParedes + "/10";
        ToString();
        if (contadorParedes == paredes.Length)
        {
            victoria.gameObject.SetActive(true);
            Debug.Log("¡Todas las paredes han sido destruidas!");
        }
    }
}
