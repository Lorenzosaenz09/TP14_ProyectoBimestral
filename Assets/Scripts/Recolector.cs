using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recolector : MonoBehaviour
{
    int score = 0;

    public int puntajeMaximo = 5;

    UIManager uiManager;

    void Awake()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    void Start()
    {

    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coleccionable"))
        {
            Destroy(other.gameObject);

            score++;

            uiManager.UpdateScore(score);

            if (score >= puntajeMaximo)
            {
                uiManager.MostrarPantallaWin();

                Time.timeScale = 0;
            }
        }
    }
}