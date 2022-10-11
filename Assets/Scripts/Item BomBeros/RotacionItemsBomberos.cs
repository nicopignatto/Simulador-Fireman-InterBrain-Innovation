using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionItemsBomberos : MonoBehaviour
{
    [Header("Vel. de rotación del Punto Focal")]
    [SerializeField] private float velRot = 65f;

    private void Update()
    {
        RotacionItemPF();
    }

    private void RotacionItemPF()
    {
        transform.Rotate(Vector3.forward * velRot * Time.deltaTime);
        
    }
}
