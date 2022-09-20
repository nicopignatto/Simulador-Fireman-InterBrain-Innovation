using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PJControlador : MonoBehaviour
{
    [Header("Velocidad de movimiento del PJ")]
    [SerializeField] private float velPJ;

    [Header("Linkeos")]
    [SerializeField] private Rigidbody rbPJ;

    private void FixedUpdate()
    {
        MovimientoPJ();
    }

    private void MovimientoPJ()
    {
        float inputHorizontal = Input.GetAxis("Horizontal");
        float inputVertical = Input.GetAxis("Vertical");

        rbPJ.velocity = new Vector3(inputVertical, 0f, inputHorizontal) * velPJ;
    }
}
