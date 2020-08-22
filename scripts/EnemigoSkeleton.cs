//Nombre del Desarrollador: Kevin Lozano Sedeño
//Asignatura: Estructura de Datos
//Descripcion del uso de este codigo:
/*
Este script se utilizara para generar que el enemigo le reste vida al jugador

*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoSkeleton : MonoBehaviour
{
    //Variables
    [SerializeField]
    ControlPlayer Playervida;

    

    private void Start()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            Playervida.Vida--;
            if (Playervida.Vida <=0)
            {
                Playervida.spritePlayer.enabled = false;
            }
        } //El enemigo al colisionar con el jugador le restara una vida, si esta llega a 0 el personaje desaparece
    }

    private void Update()
    {
       
    }

}
