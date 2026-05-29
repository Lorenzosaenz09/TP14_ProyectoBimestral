using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recolector : MonoBehaviour
{
    int contador = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    
    {
        if (other.CompareTag("Coleccionable"))
        {
            Destroy(other.gameObject);

            contador++;

            Debug.Log("Objetos recolectados: " + contador);
        }
    }
}
