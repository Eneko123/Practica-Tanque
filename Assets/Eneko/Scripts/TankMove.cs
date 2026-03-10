using UnityEngine;

public class TankMove : MonoBehaviour
{
    public int velocidad;
    public int velocidadRotacion;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // Evita que el tank se voltee por colisiones
        rb.constraints = RigidbodyConstraints.FreezeRotationX |
                         RigidbodyConstraints.FreezeRotationZ;
    }

    void FixedUpdate() // FixedUpdate para física
    {
        MoverTanque();
    }

    void MoverTanque()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.MovePosition(rb.position + transform.forward * velocidad * Time.fixedDeltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.MovePosition(rb.position - transform.forward * velocidad * Time.fixedDeltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Quaternion rotacion = Quaternion.Euler(0, velocidadRotacion * Time.fixedDeltaTime, 0);
            rb.MoveRotation(rb.rotation * rotacion);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Quaternion rotacion = Quaternion.Euler(0, -velocidadRotacion * Time.fixedDeltaTime, 0);
            rb.MoveRotation(rb.rotation * rotacion);
        }
    }
}