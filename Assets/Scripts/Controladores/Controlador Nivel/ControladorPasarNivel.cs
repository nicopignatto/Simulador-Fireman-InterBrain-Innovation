using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorPasarNivel : MonoBehaviour
{
    [Header("Tiempo antes de pasar al siguiente nivel")]
    [SerializeField] private float coldownParaSiguienteNivel;

    //variables privadas
    private float tiempoInicialParaSiguienteNivel;
    static private bool conseguiTodosLosItems;

    static public bool ConseguiTodosLosItems
    {
        get
        {
            return conseguiTodosLosItems;
        }

        set
        {
            conseguiTodosLosItems = value;
        }
    }

    private void Start()
    {
        tiempoInicialParaSiguienteNivel = 0f;
        conseguiTodosLosItems = false;
    }

    private void Update()
    {
        PasarDeNivel();
    }

    private void PasarDeNivel()
    {
        if (conseguiTodosLosItems)
        {
            if (tiempoInicialParaSiguienteNivel > coldownParaSiguienteNivel)
            {
                //Debug.Log("Se pasa de nivel");
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                tiempoInicialParaSiguienteNivel = 0f;
            }
            tiempoInicialParaSiguienteNivel += Time.deltaTime;
        }
    }
}
