using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    //public GameObject fadeOut;
    //public GameObject loadText;
    //public AudioSource buttonClick;

    public void NewGameButton()
    {
        StartCoroutine(NewGameStart());
    }

    public void QuitGameButtom()
    {
        StartCoroutine(QuitGame());
    }

    IEnumerator NewGameStart()
    {
        //fadeOut.SetActive(true);
        //buttonClick.Play();
        yield return new WaitForSeconds(0); //3.5f
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    IEnumerator QuitGame()
    {
        //fadeOut.SetActive(true);
        //buttonClick.Play();
        yield return new WaitForSeconds(1); //3.5f
        Application.Quit();
        //Debug.Log("Quit");
    }
}
