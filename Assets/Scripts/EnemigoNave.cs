using System.Collections;
using UnityEngine;

public class EnemigoNave : MonoBehaviour
{
    public Transform jugador;
    public GameObject balaPrefab;
    public float distanciaDisparo = 10f;
    public float tiempoEntreDisparos = 1f;
    public float velocidadPersecucion = 5f;
    private float tiempoDesdeUltimoDisparo;
    public GameObject monedaPrefab;

    [SerializeField] private float cantidadPuntos;
    [SerializeField] private Puntaje puntaje;

    void Update()
    {
        if (jugador == null)
        {
            return;
        }

        // Calcula la distancia entre el enemigo y el jugador
        float distanciaAlJugador = Vector2.Distance(transform.position, jugador.position);

        // Si el jugador está lo suficientemente cerca, persigue y dispara
        if (distanciaAlJugador < distanciaDisparo)
        {
            // Perseguir al jugador
            transform.position = Vector2.MoveTowards(transform.position, jugador.position, velocidadPersecucion * Time.deltaTime);

            // Disparar si ha pasado el tiempo necesario desde el último disparo
            if (Time.time - tiempoDesdeUltimoDisparo > tiempoEntreDisparos)
            {
                Disparar();
                tiempoDesdeUltimoDisparo = Time.time;
            }
        }
    }

    void Disparar()
    {
        // Crea una instancia de la bala y configura su dirección y posición
        GameObject bala = Instantiate(balaPrefab, transform.position, Quaternion.identity);
        Vector2 direccion = Vector2.down; // Dirección hacia abajo
        bala.GetComponent<Rigidbody2D>().velocity = direccion * 5f;  // Ajusta la velocidad de la bala según tus necesidades
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica si el objeto con el que colisiona tiene la etiqueta "Bala"
        if (other.CompareTag("Bala"))
        {
            // Suma puntos, destruye la bala y luego destruye al enemigo
            puntaje.SumarPuntos(cantidadPuntos);
            Destroy(other.gameObject);
            Destroy(gameObject);

            float probabilidad = Random.Range(0f, 1f);

            // Compara con la probabilidad establecida (25%)
            if (probabilidad <= 0.25f)
            {
                // Instancia la moneda en la posición actual del enemigo
                Instantiate(monedaPrefab, transform.position, Quaternion.identity);
            }
        }
    }



}

