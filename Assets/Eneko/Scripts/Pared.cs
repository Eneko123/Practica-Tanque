using UnityEngine;

public class Pared : MonoBehaviour
{
    public ParedCounter paredCounter; // Referencia al contador de paredes

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bala"))
        {
            paredCounter.ParedDestruida();
            Destroy(gameObject);
        }
    }

    //public void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Bala"))
    //    {
    //        paredCounter.contadorParedes++;
    //        Debug.Log("Pared destruida. Total: " + paredCounter.contadorParedes);
    //        Destroy(this.gameObject); 
    //    }
    //}
}
