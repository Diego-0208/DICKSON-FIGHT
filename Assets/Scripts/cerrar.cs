using UnityEngine;
using UnityEngine.UI; // Aseg�rate de incluir esta l�nea si est�s usando UI

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
