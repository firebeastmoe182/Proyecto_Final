using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPrincipal : MonoBehaviour
{
    Rigidbody rb;
    Vector2 inputMov;
    Vector2 inputRot;
    public float velocidad;
    public float sensibilidad;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        inputMov.x = Input.GetAxis("Horizontal")*velocidad;
        inputMov.y = Input.GetAxis("Vertical")*velocidad;

        inputRot.x = Input.GetAxis("Mouse X") * sensibilidad;
        inputRot.y = Input.GetAxis("Mouse Y") * sensibilidad;

    }

    private void FixedUpdate()
    {
        float vel = velocidad;
        rb.velocity = transform.forward * vel * inputMov.y + transform.right * vel * inputMov.x;
        transform.rotation *= Quaternion.Euler(0, inputRot.x, 0);
    }
}
