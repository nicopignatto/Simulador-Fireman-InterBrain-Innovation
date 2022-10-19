using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportFuego : MonoBehaviour
{
    [Header("Textura del fuego")]
    [SerializeField] private Texture texturaFuego;


    [Header("Material del fuego al apagarse")]
    [SerializeField] private MeshRenderer mRendererFuego;

    [Header("Vida del fuego")]
    [SerializeField] private int vidaFuego;

    [Header("Linkeos")]
    [SerializeField] private List<GameObject> listaDeParticulasGameObjects;

    private void Update()
    {
        MuerteFuego();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Agua"))
        {
            //Debug.Log(vidaFuego);
            vidaFuego -= 1;
        }

    }

    private void MuerteFuego()
    {
        if (vidaFuego <= 0)
        {
            mRendererFuego.material.mainTexture = texturaFuego;
            mRendererFuego.material.color = Color.clear;
            foreach (GameObject particulas in listaDeParticulasGameObjects)
            {
                particulas.SetActive(false);
            }
        }
    }
}
