using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float rotationSpeed = 700f; // Velocidad de rotación
    public float speed = 5f; // Velocidad de movimiento
    public float jumpHeight = 2f; // Altura del salto
    public float gravity = 9.81f; // Gravedad

    private CharacterController controller;
    private Animator animator;
    private Vector3 velocity;
    private bool isGrounded;

    void Start()
    {
        // Obtén el componente CharacterController
        controller = GetComponent<CharacterController>();
        // Obtén el componente Animator
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Verifica si el jugador está en el suelo
        isGrounded = controller.isGrounded;

        // Verifica el movimiento del jugador
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        // Determina la dirección del movimiento basado en las teclas presionadas
        Vector3 move = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            move = transform.forward; // Mover hacia adelante
        }
        else if (Input.GetKey(KeyCode.S))
        {
            move = -transform.forward; // Mover hacia atrás
        }
        else if (Input.GetKey(KeyCode.A))
        {
            move = -transform.right; // Mover hacia la izquierda
        }
        else if (Input.GetKey(KeyCode.D))
        {
            move = transform.right; // Mover hacia la derecha
        }

        // Verifica si el jugador está moviéndose
        bool isMoving = move != Vector3.zero;
        animator.SetBool("correr", isMoving);

        // Maneja la animación de salto
        if (isGrounded)
        {
            if (velocity.y < 0)
            {
                velocity.y = -2f; // Valor pequeño para mantener el jugador en el suelo
            }

            if (Input.GetKey(KeyCode.Space))
            {
                // Aplica una velocidad vertical para el salto
                velocity.y = Mathf.Sqrt(jumpHeight * 2f * gravity);
                animator.SetTrigger("salto");
            }
        }
        else
        {
            // Si no está en el suelo, se está en el aire y la animación de salto debería estar activa
            if (velocity.y > 0)
            {
                animator.SetTrigger("salto");
            }
        }

        // Aplica la gravedad
        velocity.y -= gravity * Time.deltaTime;

        // Mueve al jugador
        controller.Move(move * speed * Time.deltaTime + velocity * Time.deltaTime);

        // Maneja la rotación del personaje hacia la dirección de movimiento
        if (isMoving)
        {
            Quaternion toRotation = Quaternion.LookRotation(move.normalized, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
    }
}
