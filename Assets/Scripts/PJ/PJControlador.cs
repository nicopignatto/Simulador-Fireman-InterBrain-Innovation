using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PJControlador : MonoBehaviour
{
    [Header("Velocidad de movimiento del PJ")]
    [SerializeField] private float velPJ;

    [Header("Velocidad de Rotacion del PJ")]
    [SerializeField] private float velRotacionPJ;

    [Header("Tamaño de rayo/raycast de interaccion")]
    [SerializeField] private float tamañoRaycast;

    [Header("Linkeos")]
    [SerializeField] private Rigidbody rbPJ;
    [SerializeField] private GameObject puntoFocal;//esta variable representa al objeto del punto focal.
    [SerializeField] private GameObject rayoObjeto;

    //variables privadas
    private RaycastHit rayoInteraccionObjetos;//esta variable determina de donde sale el raycast.
    static private bool colisioneConSombrero;
    static private bool colisioneConGuantes;
    static private bool colisioneConTraje;
    static private bool colisioneConMochila;

    static public bool ColisioneConMochila
    {
        get
        {
            return colisioneConMochila;
        }

        set
        {
            colisioneConMochila = value;
        }
    }

    static public bool ColisioneConTraje
    {
        get
        {
            return colisioneConTraje;
        }

        set
        {
            colisioneConTraje = value;
        }
    }

    static public bool ColisioneConGuantes
    {
        get
        {
            return colisioneConGuantes;
        }

        set
        {
            colisioneConGuantes = value;
        }
    }

    static public bool ColisioneConSombrero
    {
        get
        {
            return colisioneConSombrero;
        }
        set
        {
            colisioneConSombrero = value;
        }
    }

    private void Start()
    {
        colisioneConSombrero = false;
        colisioneConGuantes = false;
        colisioneConTraje = false;
        colisioneConMochila = false;
    }

    private void Update()
    {
        RayoInteractorItems();
    }
    private void FixedUpdate()
    {
        MovimientoPJ();
    }

    private void MovimientoPJ()
    {
        float inputHorizontal = Input.GetAxis("Horizontal");
        float inputVertical = Input.GetAxis("Vertical");

        rbPJ.velocity = puntoFocal.transform.right * inputVertical * velPJ;//solamente esta linea sirve para mover hacia la rotacion del punto focal
        //rbPJ.velocity = new Vector3(rbPJ.velocity.x, 0f, inputHorizontal * velPJ);//esta linea junto con la linea de arriba no sirven para nada
        
        //rbPJ.MoveRotation(Quaternion.Euler(puntoFocal.transform.up * inputHorizontal * velRotacionPJ));
        //rbPJ.rotation = Quaternion.Euler(Vector3.up * inputHorizontal * velRotacionPJ);
    }

    private void RayoInteractorItems()
    {
        Debug.DrawRay(rayoObjeto.transform.position, -puntoFocal.transform.right.normalized * tamañoRaycast, Color.red);
        if (Physics.Raycast(rayoObjeto.transform.position, -puntoFocal.transform.right.normalized, out rayoInteraccionObjetos, tamañoRaycast))
        {
            if (rayoInteraccionObjetos.collider.CompareTag("Item Bombero Sombrero") && Input.GetKey(KeyCode.E))
            {
                colisioneConSombrero = true;
                //Debug.Log("Colisionaste con: " + rayoInteraccionObjetos.collider.tag);
            }
            /*else
            {
                colisioneConSombrero = false;
            }*/

            if (rayoInteraccionObjetos.collider.CompareTag("Item Bombero Guantes") && Input.GetKey(KeyCode.E))
            {
                colisioneConGuantes = true;
            }
            /*else
            {
                colisioneConGuantes = false;
            }*/

            if (rayoInteraccionObjetos.collider.CompareTag("Item Bombero Traje") && Input.GetKey(KeyCode.E))
            {
                colisioneConTraje = true;
            }
            /*else
            {
                colisioneConTraje = false;
            }*/

            if (rayoInteraccionObjetos.collider.CompareTag("Item Bombero Mochila") && Input.GetKey(KeyCode.E))
            {
                colisioneConMochila = true;
            }
            /*else
            {
                colisioneConMochila = false;
            }*/

            if (colisioneConSombrero && colisioneConGuantes && colisioneConTraje && ColisioneConMochila)
            {
                ControladorPasarNivel.ConseguiTodosLosItems = true;
            }
            else
            {
                ControladorPasarNivel.ConseguiTodosLosItems = false;
            }
        }

    }
}
