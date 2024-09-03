using UnityEngine;

public class DestroyOnHit : MonoBehaviour
{
    public string playerTag = "Player";  // Asegúrate de que el personaje jugador tenga esta etiqueta.
    public Animator animator;  // Referencia al Animator.

    private bool isDestroyed = false;

    void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto que colisionó tiene la etiqueta del jugador
        if (other.CompareTag(playerTag) && !isDestroyed)
        {
            isDestroyed = true;

            // Iniciar la animación del golpe
            animator.SetTrigger("Hit");

            // Destruir el objeto después de un tiempo (por ejemplo, 0.5 segundos) para que la animación se reproduzca.
            Destroy(gameObject, 0.5f);
        }
    }
}
