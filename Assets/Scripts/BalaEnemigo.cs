using UnityEngine;

public class BalaEnemiga : MonoBehaviour
{
    public float velocidad = 5f;
    public int cantidadDano = 1;  // Cantidad de daño causado por la bala
    public float destroyTime = 3f;


    void Start()
    {
        // Establece la dirección de movimiento hacia abajo
        GetComponent<Rigidbody2D>().velocity = Vector2.down * velocidad;
        Destroy(gameObject, destroyTime);

    }

    void Update()
    {
        // Puedes agregar más lógica aquí según sea necesario
    }


}
