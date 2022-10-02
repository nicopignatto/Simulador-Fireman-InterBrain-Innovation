using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportExtintor : MonoBehaviour
{
    [Header("Linkeos")]
    [SerializeField] private GameObject aguaGameObject;//esta variable representa al objeto "agua"
    [SerializeField] private GameObject espumaGameObject;

    private void Start()
    {
        aguaGameObject.SetActive(false);
    }

    private void Update()
    {
        ActivarExtintor();
    }

    private void ActivarExtintor()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            espumaGameObject.SetActive(true);
            aguaGameObject.SetActive(true);
        }
        else
        {
            espumaGameObject.SetActive(false);
            aguaGameObject.SetActive(false);
        }
    }
}
