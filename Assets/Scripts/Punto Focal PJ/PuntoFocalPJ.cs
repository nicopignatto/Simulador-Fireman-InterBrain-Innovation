using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntoFocalPJ : MonoBehaviour
{
    [Header("Velocidad de rotación del punto focal")]
    [SerializeField] private float velRotPuntoFocal;

    void Update()
    {
        RotacionPF();
    }

    private void RotacionPF()
    {
        float inputHorizontalPF = Input.GetAxis("Horizontal Punto Focal");
        transform.Rotate(Vector3.up * inputHorizontalPF * velRotPuntoFocal);
    }
}
