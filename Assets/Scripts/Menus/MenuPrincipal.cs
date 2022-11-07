using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
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
        yield return new WaitForSeconds(0); //3.5f
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    IEnumerator QuitGame()
    {
        yield return new WaitForSeconds(1); //3.5f
        Application.Quit();
    }
}
