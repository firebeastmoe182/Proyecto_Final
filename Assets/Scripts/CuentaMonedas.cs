using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CuentaMonedas : MonoBehaviour
{

    public MovimientoPrincipal mov;
    public Reloj tiempo;
    public int Cantidad;
    [Tooltip("Cantidad de monedas en total")]
    public int MonedasTotales;
    public Text Puntuacion;
    public Text Ganaste;
    public Text Perdiste;
    public string ganaste;
    public GameObject MenuGanaste;


    // Start is called before the first frame update
    void Start()
    {
        Cantidad = 0;
        Puntuacion.text = Cantidad.ToString("00");
        mov = GameObject.FindGameObjectWithTag("Player").GetComponent<MovimientoPrincipal>();
        tiempo = GameObject.FindGameObjectWithTag("Player").GetComponent<Reloj>();
        MenuGanaste.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       if (Cantidad == MonedasTotales )
        {
            mov.sensibilidad = 0;
            mov.velocidad = 0;
            ganaste = "GANASTE";
            MenuGanaste.gameObject.SetActive(true);
        }
    }
}
