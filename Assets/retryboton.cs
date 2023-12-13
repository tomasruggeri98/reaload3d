using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryBoton : MonoBehaviour
{
    public void OnRetryButtonPress()
    {
        // Retrocede una escena (si es posible)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}

