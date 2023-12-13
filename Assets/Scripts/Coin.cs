using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    [SerializeField] private float cantidadPuntos;
    [SerializeField] private Puntaje puntaje;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica si el objeto con el que colisiona tiene la etiqueta "Bala"
        if (other.CompareTag("Player"))
        {
            
            puntaje.SumarPuntos(cantidadPuntos);
            Destroy(gameObject);
        }
    }
}
