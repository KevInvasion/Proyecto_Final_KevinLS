//Nombre del Desarrollador: Kevin Lozano Sedeño
//Asignatura: Estructura de Datos
//Descripcion del uso de este codigo:
/*
Este script se utilizara para generar el conteo y valor del item dulce

*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dulce : MonoBehaviour
{
    //variables
    public int dulceValue = 1; //Guarda que cada item dulce vale 1

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ScoreManager.instance.ChangeScore(dulceValue);
        } //llama al script score para que al momento que el player colisone con un dulce, sume al contador
        //el valor del dulce
    }
}
