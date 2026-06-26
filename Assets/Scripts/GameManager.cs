using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float timer = 60f;

    public UIManager uiManager;

    public bool juegoTerminado = false;

    void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        if (juegoTerminado && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (!juegoTerminado)
        {
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                timer = 0;

                uiManager.MostrarPantallaGameOver();

                juegoTerminado = true;

                Time.timeScale = 0;
            }

            uiManager.UpdateTimer(timer);
        }
    }
}