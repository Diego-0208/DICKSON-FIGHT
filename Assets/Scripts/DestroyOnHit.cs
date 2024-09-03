using UnityEngine;

public class DestroyOnHit : MonoBehaviour
{
    public string playerTag = "Player";  // Aseg�rate de que el personaje jugador tenga esta etiqueta.
    public Animator animator;  // Referencia al Animator.

    private bool isDestroyed = false;

    void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto que colision� tiene la etiqueta del jugador
        if (other.CompareTag(playerTag) && !isDestroyed)
        {
            isDestroyed = true;

            // Iniciar la animaci�n del golpe
            animator.SetTrigger("Hit");

            // Destruir el objeto despu�s de un tiempo (por ejemplo, 0.5 segundos) para que la animaci�n se reproduzca.
            Destroy(gameObject, 0.5f);
        }
    }
}
