using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // Aseg�rate de tener este using para acceder a UI elements

public class RestartLevel : MonoBehaviour
{
    // Asigna el bot�n desde el Inspector en Unity
    public Button restartButton;

    private void Start()
    {
        // Verifica que el bot�n no sea nulo
        if (restartButton != null)
        {
            // Suscr�bete al evento OnClick del bot�n
            restartButton.onClick.AddListener(RestartCurrentLevel);
        }
        else
        {
            Debug.LogWarning("No se ha asignado el bot�n en el Inspector.");
        }
    }

    private void RestartCurrentLevel()
    {
        // Obt�n el nombre de la escena actual
        string currentSceneName = SceneManager.GetActiveScene().name;

        // Carga la escena actual
        SceneManager.LoadScene(currentSceneName);
    }
}
