//Nombre del Desarrollador: Kevin Lozano Sedeño
//Asignatura: Estructura de Datos
//Descripcion del uso de este codigo:
/*
Este script se utilizara para generar el seguimiento de camara del juego hacia el jugador

*/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFollow : MonoBehaviour
{
    public Transform target; //buscara al jugador
    public Vector3 puntoInicial;


    // Start is called before the first frame update
    void Start()
    {
        puntoInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + puntoInicial; //Realizara el movimiento desde el punto inicial del personaje
    }
}
