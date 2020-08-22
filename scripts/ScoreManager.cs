//Nombre del Desarrollador: Kevin Lozano Sedeño
//Asignatura: Estructura de Datos
//Descripcion del uso de este codigo:
/*
Este script se utilizara para generar el texto Score de los dulces

*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    //Variables
    public static ScoreManager instance;
    public TextMeshProUGUI texto;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }


    public void ChangeScore(int dulceValue)
    {
        score += dulceValue;
        texto.text = "X" + score.ToString();
    } //Cambiara el numero sumando los dulces cuando el player los recolecte, llamando al script dulce
}
