using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportFuego : MonoBehaviour
{
    [Header("Material del fuego al apagarse")]
    [SerializeField] private MeshRenderer mRendererFuego;
    void Start()
    {
        mRendererFuego.material.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
