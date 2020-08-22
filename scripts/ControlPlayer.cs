//Nombre del Desarrollador: Kevin Lozano Sedeño
//Asignatura: Estructura de Datos
//Descripcion del uso de este codigo:
/*
Este script se utilizara para generar todos los movimientos de nuestro jugador

*/

using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
    //Variables
    Rigidbody2D fisicasRB2D;
    public float velocidadPersonaje;
    public float FuerzaSalto;
    public SpriteRenderer spritePlayer;
    public float FuerzaSaltoPer;
    Animator CalabazaAnimacion;
    public int Vida;

    //Voltear de direccion
    bool Voltearjugador = true;

    bool SeMueve = true;

    //Accion Salto animacion
    bool EnSuelo = false;
    float RadioSuelo = 0.2f;
    public LayerMask CapaSuelo;
    public Transform CheckSuelo;


    // Start is called before the first frame update
    void Start()
    {
        fisicasRB2D = GetComponent<Rigidbody2D>();
        spritePlayer = GetComponent<SpriteRenderer>();
        velocidadPersonaje = 5.0f;
        FuerzaSaltoPer = 5.0f;

        CalabazaAnimacion = GetComponent<Animator>();

        Vida = 3;

    }

    // Update is called once per frame
    void Update()
    {
        //Accion movimiento en x
        if (SeMueve && EnSuelo && Input.GetAxis("Jump") >0)
        {
            CalabazaAnimacion.SetBool("EnElSuelo", false);
            fisicasRB2D.velocity = new Vector2(fisicasRB2D.velocity.x, 0f);
            fisicasRB2D.AddForce(new Vector2(0, FuerzaSalto), ForceMode2D.Impulse);
            EnSuelo = false;
        }
        EnSuelo = Physics2D.OverlapCircle(CheckSuelo.position, RadioSuelo, CapaSuelo);
        CalabazaAnimacion.SetBool("EnElSuelo", EnSuelo);
        
        
        float mover = Input.GetAxis("Horizontal");
        

        if (SeMueve)
        {
            if (mover > 0 && !Voltearjugador)
            {
                voltear();
            }
            else if (mover < 0 && Voltearjugador)
            {
                voltear();
            }//Voltea de direccion al jugador hacia donde se esta dirigiendo

            fisicasRB2D.velocity = new Vector2(mover * velocidadPersonaje, fisicasRB2D.velocity.y);

            //Accion Correr
            CalabazaAnimacion.SetFloat("Velocidad Movimiento", Mathf.Abs(mover));
        }
        else
        {
            fisicasRB2D.velocity = new Vector2(0, fisicasRB2D.velocity.y);

            //Accion Correr
            CalabazaAnimacion.SetFloat("Velocidad Movimiento", 0);
        }

        

        //Accion saltar
        if (Input.GetKeyDown(KeyCode.Space) && EnSuelo)
        {
            fisicasRB2D.AddForce(Vector2.up * FuerzaSaltoPer, ForceMode2D.Impulse);
        }



    }

    void voltear()
    {
        Voltearjugador = !Voltearjugador; 
        spritePlayer.flipX = !spritePlayer.flipX;
    }

    public void toggleSeMueve()
    {
        SeMueve = !SeMueve;
    }
    //Dulces
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Dulces"))
        {
            Destroy(other.gameObject);
        }//Esta declaracion hace que los dulces al momento que el jugador colisiona con ellos desaparezcan
    }

}
