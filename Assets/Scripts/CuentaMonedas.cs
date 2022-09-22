﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CuentaMonedas : MonoBehaviour
{

    public MovimientoPrincipal mov;
    public int Cantidad;
    [Tooltip("Cantidad de monedas en total")]
    public int Coings;
    public Text Puntuacion;
    public Text Ganaste;
    public Text Perdiste;
    public string ganaste;


    // Start is called before the first frame update
    void Start()
    {
        Cantidad = 0;
        Puntuacion.text = Cantidad.ToString("00");
        mov = GameObject.FindGameObjectWithTag("Player").GetComponent<MovimientoPrincipal>();
    }

    // Update is called once per frame
    void Update()
    {
       if (Cantidad == Coings )
        {
            mov.velocidad = 0;
            ganaste = "GANASTE";
            Ganaste.text = ganaste;
        }
    }
}
