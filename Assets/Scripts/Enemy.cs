using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int attackDamage = 10;
    public Animator animator;
    public string attackAnimationName = "Attack";
    private bool hasAttacked = false;

    void Update()
    {
        // Verifica si la animación de golpe se está reproduciendo
        if (animator.GetCurrentAnimatorStateInfo(0).IsName(attackAnimationName))
        {
            // Si no ha atacado aún, ataca
            if (!hasAttacked)
            {
                
                hasAttacked = true;
            }
        }
        else
        {
            // Resetea el ataque cuando la animación termina
            hasAttacked = false;
        }
    }
}            