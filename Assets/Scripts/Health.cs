using UnityEngine;

public class Health : MonoBehaviour
{
    // Vida máxima del personaje
    public int maxHealth = 100;
    // Vida actual del personaje
    private int currentHealth;

    // Evento que se llama cuando el personaje muere
    public delegate void OnDeath();
    public event OnDeath onDeath;

    void Start()
    {
        // Inicializamos la vida actual con la vida máxima al empezar
        currentHealth = maxHealth;
    }

    // Método para aplicar daño
    public void TakeDamage(int damage)
    {
        // Reducimos la vida actual por el valor del daño
        currentHealth -= damage;

        // Aseguramos que la vida no baje de cero
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Die();
        }
    }

    // Método para aplicar curación
    public void Heal(int amount)
    {
        // Aumentamos la vida actual por el valor de la curación
        currentHealth += amount;

        // Aseguramos que la vida no supere la vida máxima
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }

    // Método para manejar la muerte del personaje
    void Die()
    {
        // Llamamos al evento onDeath si hay suscriptores
        onDeath?.Invoke();

        // Aquí puedes añadir la lógica que desees al morir el personaje, como destruir el objeto
        Debug.Log($"{gameObject.name} ha muerto.");
        // Destruir el objeto (opcional, dependiendo de la lógica del juego)
        Destroy(gameObject);
    }

    // Método para obtener la vida actual
    public int GetCurrentHealth()
    {
        return currentHealth;
    }
}
