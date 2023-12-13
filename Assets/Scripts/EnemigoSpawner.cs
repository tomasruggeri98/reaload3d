using UnityEngine;

public class EnemigoSpawner : MonoBehaviour
{
    public GameObject enemigoPrefab; // Prefab del enemigo a instanciar
    public float tiempoMinSpawn = 1f; // Tiempo mínimo entre cada spawn
    public float tiempoMaxSpawn = 3f; // Tiempo máximo entre cada spawn
    public Transform[] puntosSpawn; // Puntos donde pueden aparecer los enemigos

    void Start()
    {
        // Inicia la rutina de spawn
        Invoke("SpawnearEnemigo", Random.Range(tiempoMinSpawn, tiempoMaxSpawn));
    }

    void SpawnearEnemigo()
    {
        // Elige aleatoriamente uno de los puntos de spawn
        int indicePuntoSpawn = Random.Range(0, puntosSpawn.Length);
        Transform puntoSpawn = puntosSpawn[indicePuntoSpawn];

        // Instancia el enemigo en el punto seleccionado
        Instantiate(enemigoPrefab, puntoSpawn.position, Quaternion.identity);

        // Vuelve a programar la invocación con un nuevo tiempo aleatorio
        Invoke("SpawnearEnemigo", Random.Range(tiempoMinSpawn, tiempoMaxSpawn));
    }
}

