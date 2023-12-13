using UnityEngine;

public class BalaEnemiga : MonoBehaviour
{
    public float velocidad = 5f;
    public int cantidadDano = 1;  // Cantidad de da�o causado por la bala
    public float destroyTime = 3f;


    void Start()
    {
        // Establece la direcci�n de movimiento hacia abajo
        GetComponent<Rigidbody2D>().velocity = Vector2.down * velocidad;
        Destroy(gameObject, destroyTime);

    }

    void Update()
    {
        // Puedes agregar m�s l�gica aqu� seg�n sea necesario
    }


}
