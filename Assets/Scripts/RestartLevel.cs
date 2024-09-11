using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // Asegúrate de tener este using para acceder a UI elements

public class RestartLevel : MonoBehaviour
{
    // Asigna el botón desde el Inspector en Unity
    public Button restartButton;

    private void Start()
    {
        // Verifica que el botón no sea nulo
        if (restartButton != null)
        {
            // Suscríbete al evento OnClick del botón
            restartButton.onClick.AddListener(RestartCurrentLevel);
        }
        else
        {
            Debug.LogWarning("No se ha asignado el botón en el Inspector.");
        }
    }

    private void RestartCurrentLevel()
    {
        // Obtén el nombre de la escena actual
        string currentSceneName = SceneManager.GetActiveScene().name;

        // Carga la escena actual
        SceneManager.LoadScene(currentSceneName);
    }
}
