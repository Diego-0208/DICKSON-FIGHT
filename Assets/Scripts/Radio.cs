using UnityEngine;

public class Radio : MonoBehaviour
{
    // El clip de audio que va a sonar en la radio
    public AudioClip radioMusic;

    // El componente AudioSource que reproducir� la m�sica
    private AudioSource audioSource;

    void Start()
    {
        // Obt�n el componente AudioSource en el mismo objeto
        audioSource = GetComponent<AudioSource>();

        // Asigna el clip de m�sica al AudioSource
        audioSource.clip = radioMusic;

        // Reproduce la m�sica en bucle
        audioSource.loop = true;
        audioSource.Play();
    }

    // M�todo para encender la radio
    public void TurnOn()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }

    // M�todo para apagar la radio
    public void TurnOff()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }

    // M�todo para pausar la radio
    public void Pause()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Pause();
        }
    }

    // M�todo para reanudar la radio despu�s de pausar
    public void Resume()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.UnPause();
        }
    }
}
