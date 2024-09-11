using UnityEngine;
using UnityEngine.UI; // Necesario para acceder a UI elements

public class VolumeControl : MonoBehaviour
{
    // Asigna el Slider desde el Inspector en Unity
    public Slider volumeSlider;

    private void Start()
    {
        // Verifica que el slider no sea nulo
        if (volumeSlider != null)
        {
            // Configura el valor inicial del slider para que corresponda al volumen actual
            volumeSlider.value = AudioListener.volume;

            // Suscríbete al evento OnValueChanged del slider
            volumeSlider.onValueChanged.AddListener(SetVolume);
        }
        else
        {
            Debug.LogWarning("No se ha asignado el Slider en el Inspector.");
        }
    }

    // Método para ajustar el volumen
    private void SetVolume(float value)
    {
        AudioListener.volume = value;
    }
}
