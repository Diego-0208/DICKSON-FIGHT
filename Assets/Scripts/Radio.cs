using UnityEngine;

public class Radio : MonoBehaviour
{
    // El clip de audio que va a sonar en la radio
    public AudioClip radioMusic;

    // El componente AudioSource que reproducirá la música
    private AudioSource audioSource;

    void Start()
    {
        // Obtén el componente AudioSource en el mismo objeto
        audioSource = GetComponent<AudioSource>();

        // Asigna el clip de música al AudioSource
        audioSource.clip = radioMusic;

        // Reproduce la música en bucle
        audioSource.loop = true;
        audioSource.Play();
    }

    // Método para encender la radio
    public void TurnOn()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }

    // Método para apagar la radio
    public void TurnOff()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }

    // Método para pausar la radio
    public void Pause()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Pause();
        }
    }

    // Método para reanudar la radio después de pausar
    public void Resume()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.UnPause();
        }
    }
}
