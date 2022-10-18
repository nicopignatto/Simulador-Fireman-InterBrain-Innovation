using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorRecogerItems : MonoBehaviour
{
    [Header("Linkeos")]
    [SerializeField] private GameObject sombreroItemObjeto;//esta var. representa al objeto item del fireman
    [SerializeField] private GameObject sombreroObjPJ;//esta var. representa al objeto del PJ
    [SerializeField] private GameObject guantesItemObjeto;//esta var. representa al objeto item del fireman
    [SerializeField] private GameObject guantesObjPJ;//esta var. representa al objeto del PJ
    [SerializeField] private GameObject trajeItemObjeto;
    [SerializeField] private GameObject trajeObjPJ;
    [SerializeField] private GameObject mochilaItemObjeto;
    [SerializeField] private GameObject mochilaObjPJ;

    private void Start()
    {
        sombreroObjPJ.SetActive(false); 
        guantesObjPJ.SetActive(false);
        trajeObjPJ.SetActive(false);
        mochilaObjPJ.SetActive(false);
    }

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
