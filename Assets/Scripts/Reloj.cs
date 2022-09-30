using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reloj : MonoBehaviour
{
    [Tooltip("Tiempo iniciar en Segundos")]
    public int tiempoinicial;
    [Tooltip("Escala del timepo del Reloj")]
    [Range(-10.0f, 10.0f)]
    public float escalaDeTiempo = 1;

    private Text myText;
    public Text Perdiste;

    public MovimientoPrincipal mov;
    public CuentaMonedas monedas;

    public float TiempoFrameConTiempoScale = 0f;
    public float TiempoMostradoEnSegundos = 0f;
    private float escalaDeTiempoInicial;
    public GameObject MenuPerdiste;
    

    // Start is called before the first frame update
    void Start()
    {
        escalaDeTiempoInicial = escalaDeTiempo;
        myText = GetComponent<Text>();
        TiempoMostradoEnSegundos = tiempoinicial;
        mov = GameObject.FindGameObjectWithTag("Player").GetComponent<MovimientoPrincipal>();
        monedas = GameObject.FindGameObjectWithTag("Player").GetComponent<CuentaMonedas>();
        MenuPerdiste.gameObject.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {

        TiempoFrameConTiempoScale = Time.deltaTime * escalaDeTiempo;
        TiempoMostradoEnSegundos += TiempoFrameConTiempoScale;
        ActualizarReloj(TiempoMostradoEnSegundos);
       

        
    }

    public void ActualizarReloj(float TiempoEnSegundos)
    {
        int minutos = 0;
        int segundos = 0;

        string textoDelReloj;

        if (TiempoEnSegundos < 0) TiempoEnSegundos = 0;

        minutos = (int)TiempoEnSegundos / 60;
        segundos = (int)TiempoEnSegundos % 60;

        textoDelReloj = minutos.ToString("00") + ":" + segundos.ToString("00");
        myText.text = textoDelReloj;

        if (textoDelReloj == "00:00")
        {
            mov.sensibilidad = 0;
            mov.velocidad = 0;
            MenuPerdiste.gameObject.SetActive(true);

        }

        if (monedas.ganaste == "GANASTE")
        {
            escalaDeTiempo = 0;
        }

    }
}
