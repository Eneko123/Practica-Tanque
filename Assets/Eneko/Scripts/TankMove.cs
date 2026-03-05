using UnityEngine;

public class TankMove : MonoBehaviour
{
    public Collider col;
    public int velocidad;
    public int velocidadRotacion;
    public bool isColliding = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        if (isColliding)
        {
            if (Input.GetKey(KeyCode.D))
            {
                this.gameObject.transform.Rotate(Vector3.up * Time.deltaTime * velocidadRotacion);
            }
            if (Input.GetKey(KeyCode.A))
            {
                this.gameObject.transform.Rotate(Vector3.down * Time.deltaTime * velocidadRotacion);
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.W))
            {
                this.gameObject.transform.Translate(Vector3.forward * Time.deltaTime * velocidad);
            }
            if (Input.GetKey(KeyCode.S))
            {
                this.gameObject.transform.Translate(Vector3.back * Time.deltaTime * velocidad);
            }
            if (Input.GetKey(KeyCode.D))
            {
                this.gameObject.transform.Rotate(Vector3.up * Time.deltaTime * velocidadRotacion);
            }
            if (Input.GetKey(KeyCode.A))
            {
                this.gameObject.transform.Rotate(Vector3.down * Time.deltaTime * velocidadRotacion);
            }
        }
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    for (int i = 0; i < col.transform.childCount; i++)
    //    {
    //        if (other.gameObject == col.transform.GetChild(i).gameObject)
    //        {
    //            isColliding = true;
    //        }
    //    }
    //}

    //private void OnTriggerExit(Collider other)
    //{
    //    for (int i = 0; i < col.transform.childCount; i++)
    //    {
    //        if (other.gameObject == col.transform.GetChild(i).gameObject)
    //        {
    //            isColliding = true;
    //        }
    //    }
    //}
}
