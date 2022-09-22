using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coing : MonoBehaviour
{
    public CuentaMonedas cuentamonedas;
    //Start is called before the first frame update
    void Start()
    {
        cuentamonedas = GameObject.FindGameObjectWithTag("Player").GetComponent<CuentaMonedas>(); 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            cuentamonedas.Cantidad++;
            cuentamonedas.Puntuacion.text = cuentamonedas.Cantidad.ToString("00");
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
