using UnityEngine;

public class TorretaMove : MonoBehaviour
{
    public GameObject torreta;
    public Transform point;

    public int velocidadRotacion;
    public float anguloMinVertical = -10f;
    public float anguloMaxVertical = 30f;

    private float anguloVerticalActual = 0f;

    void FixedUpdate() // FixedUpdate para física
    {
        RotarTorreta();
    }

    private void Update()
    {
        this.transform.position = point.position;
    }

    void RotarTorreta()
    {
        float horizontal = 0f;
        float vertical = 0f;

        if (Input.GetKey(KeyCode.RightArrow)) horizontal = 1f;
        if (Input.GetKey(KeyCode.LeftArrow)) horizontal = -1f;

        if (Input.GetKey(KeyCode.UpArrow)) vertical = -1f;
        if (Input.GetKey(KeyCode.DownArrow)) vertical = 1f;

        if (horizontal != 0f)
            torreta.transform.Rotate(Vector3.up, horizontal * velocidadRotacion * Time.fixedDeltaTime, Space.World);

        if (vertical != 0f)
        {
            anguloVerticalActual += vertical * velocidadRotacion * Time.fixedDeltaTime;
            anguloVerticalActual = Mathf.Clamp(anguloVerticalActual, anguloMinVertical, anguloMaxVertical);

            Vector3 euler = torreta.transform.localEulerAngles;
            torreta.transform.localRotation = Quaternion.Euler(anguloVerticalActual, euler.y, 0f);
        }
    }
}
