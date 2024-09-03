using UnityEngine;
using UnityEngine.SceneManagement; // Necesario para cargar escenas

public class Health : MonoBehaviour
{
    // Vida m�xima del personaje
    public int maxHealth = 100;
    // Vida actual del personaje
    private int currentHealth;

    // Evento que se llama cuando el personaje muere
    public delegate void OnDeath();
    public event OnDeath onDeath;

    void Start()
    {
        // Inicializamos la vida actual con la vida m�xima al empezar
        currentHealth = maxHealth;
    }

    // M�todo para aplicar da�o
    public void TakeDamage(int damage)
    {
        // Reducimos la vida actual por el valor del da�o
        currentHealth -= damage;

        // Aseguramos que la vida no baje de cero
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Die();
        }
    }

    // M�todo para aplicar curaci�n
    public void Heal(int amount)
    {
        // Aumentamos la vida actual por el valor de la curaci�n
        currentHealth += amount;

        // Aseguramos que la vida no supere la vida m�xima
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }

    // M�todo para manejar la muerte del personaje
    void Die()
    {
        // Llamamos al evento onDeath si hay suscriptores
        onDeath?.Invoke();

        // Aqu� puedes a�adir la l�gica que desees al morir el personaje
        Debug.Log($"{gameObject.name} ha muerto.");

        // Cargar la escena de Game Over
        SceneManager.LoadScene("GameOverMenu");

        // Destruir el objeto (opcional, dependiendo de la l�gica del juego)
        Destroy(gameObject);
    }

    // M�todo para obtener la vida actual
    public int GetCurrentHealth()
    {
        return currentHealth;
    }
}


