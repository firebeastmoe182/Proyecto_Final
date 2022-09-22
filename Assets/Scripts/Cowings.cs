using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cowings : MonoBehaviour
{
    public Tiempo tiempo;
    public CuentaMonedas cuentamonedas;
    public bool tocar = false;

    // Start is called before the first frame update
    void Start()
    {
        cuentamonedas = GameObject.FindGameObjectWithTag("Player").GetComponent<CuentaMonedas>();
        tiempo = GameObject.FindGameObjectWithTag("Tiempo").GetComponent<Tiempo>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            cuentamonedas.Cantidad++;
            cuentamonedas.Puntuacion.text = cuentamonedas.Cantidad.ToString("00");
            tiempo.TiempoMostradoEnSegundos += 15f;
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
