using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorRecogerItems : MonoBehaviour
{
    [Header("Linkeos")]
    [SerializeField] private GameObject sombreroItemObjeto;//esta var. representa al objeto item del fireman
    [SerializeField] private GameObject sombreroObjPJ;//esta var. representa al objeto del PJ
    [SerializeField] private GameObject guantesItemObjeto;
    [SerializeField] private GameObject guantesObjPJ;
    [SerializeField] private GameObject trajeItemObjeto;
    [SerializeField] private GameObject trajeObjPJ;
    [SerializeField] private GameObject mochilaItemObjeto;
    [SerializeField] private GameObject mochilaObjPJ;

    private void Update()
    {
        RecogimientoDeItems();
    }

    private void RecogimientoDeItems()
    {
        if (PJControlador.ColisioneConSombrero)
        {
            sombreroItemObjeto.SetActive(false);
            sombreroObjPJ.SetActive(true);
        }

        if (PJControlador.ColisioneConGuantes)
        {
            guantesItemObjeto.SetActive(false);
            guantesObjPJ.SetActive(true);
        }

        if (PJControlador.ColisioneConTraje)
        {
            trajeItemObjeto.SetActive(false);
            trajeObjPJ.SetActive(true);
        }

        if (PJControlador.ColisioneConMochila)
        {
            mochilaItemObjeto.SetActive(false);
            mochilaObjPJ.SetActive(true);
        }
    }
}
