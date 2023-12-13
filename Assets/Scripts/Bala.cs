using UnityEngine;

public class Bala : MonoBehaviour
{
    public float bulletSpeed = 10f;
    public float destroyTime = 3f;

    void Start()
    {
        // Autodestrucci�n de la bala despu�s de 'destroyTime' segundos
        Destroy(gameObject, destroyTime);
    }

    void Update()
    {
        // Movimiento de la bala
        transform.Translate(Vector2.up * bulletSpeed * Time.deltaTime);
    }

}
