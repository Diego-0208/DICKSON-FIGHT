using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int attackDamage = 10;
    public Animator animator;
    public string attackAnimationName = "Attack";
    private bool hasAttacked = false;

    void Update()
    {
        // Verifica si la animaci�n de golpe se est� reproduciendo
        if (animator.GetCurrentAnimatorStateInfo(0).IsName(attackAnimationName))
        {
            // Si no ha atacado a�n, ataca
            if (!hasAttacked)
            {
                
                hasAttacked = true;
            }
        }
        else
        {
            // Resetea el ataque cuando la animaci�n termina
            hasAttacked = false;
        }
    }
}            