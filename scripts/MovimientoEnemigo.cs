//Nombre del Desarrollador: Kevin Lozano Sedeño
//Asignatura: Estructura de Datos
//Descripcion del uso de este codigo:
/*
Este script se utilizara para generar el movimiento del Enemigo

*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour
{
    //Variables
    [SerializeField]
    float Velocidad;

    [SerializeField]
    float Distancia;

    [SerializeField]
    Vector3[] PosInicial;

    [SerializeField]
    Transform[] Enemigo;


    // Start is called before the first frame update
    void Start()
    {
        PosInicial = new Vector3[Enemigo.Length];
        //PosInicial = transform.position;
        for (int i = 0; i < Enemigo.Length; i++)
        {
            PosInicial[i]= Enemigo[i].position;
        } //Array que guardara las posiciones iniciales de cada enemigo
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posSeno = new Vector3(Mathf.Sin(Time.time * Velocidad) * Distancia, 0, 0);
        
        for (int i = 0; i < Enemigo.Length; i++)
        {
            Enemigo[i].position = PosInicial[i] + posSeno;
        } //Realiza el movimiento en x del enemigo, con la distancia asignada por el desarrollador
    }
}
