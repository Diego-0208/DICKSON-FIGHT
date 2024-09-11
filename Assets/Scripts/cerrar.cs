using UnityEngine;
using UnityEngine.UI; // Asegúrate de incluir esta línea si estás usando UI

public class ExitGameButton : MonoBehaviour
{


    void Start()
    {

    }

    public void OnExitButtonClick()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
