using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionItemsBombero : MonoBehaviour
{
    [Header("Vel. de rotación del Punto Focal")]
    [SerializeField] private float velRotPF = 65;

    [Header("Linkeos")]
    [SerializeField] private GameObject pFocalObjeto;

    private void Update()
    {
        RotacionItemPF();
    }

    private void RotacionItemPF()
    {
        float inputHorizontalPF = Input.GetAxis("Horizontal Punto Focal");
        transform.Rotate(Vector3.up * inputHorizontalPF * velRotPF * Time.deltaTime);
    }
}
