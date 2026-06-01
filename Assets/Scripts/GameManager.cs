using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float timer = 60f;
    public UIManager uiManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
void Update()
    {
        timer -= Time.deltaTime;

        if (timer < 0)
        {
            timer = 0;
        }

        uiManager.UpdateTimer(timer);
    }
}