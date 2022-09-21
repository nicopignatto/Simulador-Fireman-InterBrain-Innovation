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
    static private bool colisioneConItem;

    static public bool ColisioneConItem
    {
        get
        {
            return colisioneConItem;
        }
        set
        {
            colisioneConItem = value;
        }
    }

    private void Start()
    {
        colisioneConItem = false;   
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
            if (rayoInteraccionObjetos.collider.CompareTag("Item Bombero") && Input.GetKey(KeyCode.E))
            {
                colisioneConItem = true;
                Debug.Log("Colisionaste con: " + rayoInteraccionObjetos.collider.tag);
            }
            else
            {
                colisioneConItem = false;
            }
        }

    }
}
