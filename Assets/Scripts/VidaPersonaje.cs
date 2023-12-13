using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class VidaPersonaje : MonoBehaviour
{

    [SerializeField] int vidas;
    [SerializeField] Slider sliderVidas;
    public Canvas canvasMuerte;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.gameObject.CompareTag("BalaEnemiga"))
        {
            vidas--;
            sliderVidas.value = vidas;

            if (vidas == 0)
            {
                Destroy(gameObject);
                canvasMuerte.gameObject.SetActive(true);
            }
        }
    }
}
