using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovimientoPrincipal : MonoBehaviour
{
    Rigidbody rb;
    Vector2 inputMov;
    Vector2 inputRot;
    public float velocidad;
    public float sensibilidad;
    public GameObject[] Camaras;
    public GameObject pausa;
    private bool menupausa;
    public GameObject Marcador;
    Reloj reloj;


    private void Start()
    {
        reloj = GameObject.FindGameObjectWithTag("Tiempo").GetComponent<Reloj>();
        rb = GetComponent<Rigidbody>();
        Camaras[0].gameObject.SetActive(true);
        Camaras[1].gameObject.SetActive(false);
        Marcador.gameObject.SetActive(true);
        pausa.gameObject.SetActive(false);
    }

    private void Update()
    {
        inputMov.x = Input.GetAxis("Horizontal");
        inputMov.y = Input.GetAxis("Vertical");

        inputRot.x = Input.GetAxis("Mouse X") * sensibilidad;
        inputRot.y = Input.GetAxis("Mouse Y") * sensibilidad;

        if(Input.GetKey(KeyCode.Alpha1))
        {
            Camaras[0].gameObject.SetActive(true);
            Camaras[1].gameObject.SetActive(false);
            Marcador.gameObject.SetActive(true);
            reloj.escalaDeTiempo = -1;
            velocidad = 40;
            sensibilidad = 10;

        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            Camaras[0].gameObject.SetActive(false);
            Camaras[1].gameObject.SetActive(true);
            Marcador.gameObject.SetActive(false);
            reloj.escalaDeTiempo = 0;
            velocidad = 0;
            sensibilidad = 0;
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            menupausa = !menupausa;
        }
        if (menupausa == true)
        {
            pausa.gameObject.SetActive(true);
            reloj.escalaDeTiempo = 0;
            velocidad = 0;
            sensibilidad = 0;
        }
        else
        {
            pausa.gameObject.SetActive(false);
        }

    }
 

    private void FixedUpdate()
    {
        float vel = velocidad;
        rb.velocity = transform.forward * vel * inputMov.y + transform.right * vel * inputMov.x;
        transform.rotation *= Quaternion.Euler(0, inputRot.x, 0);
    }

}
