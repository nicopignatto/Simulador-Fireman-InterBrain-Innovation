using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IrAlMenu : MonoBehaviour
{
    public int tiempoEspera;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PasardeNivel()); 
    }

    IEnumerator PasardeNivel()
    {
        yield return new WaitForSeconds(tiempoEspera);
        SceneManager.LoadScene(0);
    }
}
