using UnityEngine;
using UnityEngine.InputSystem; 

public class Player : MonoBehaviour
{
    public float velocidade = 5f;
    private Rigidbody rb;
    public InputActionProperty moveAction; 

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    void Update()
    {
        // Teclado (WASD / Setas)
        float moveHorizontal = Input.GetAxis("Horizontal"); 
        float moveVertical = Input.GetAxis("Vertical");     

        // VR (Quest 3)
        Vector2 inputVR = moveAction.action.ReadValue<Vector2>();
        if (inputVR != Vector2.zero)
        {
            moveHorizontal = inputVR.x;
            moveVertical = inputVR.y;
        }

        // Criar a direção
        Vector3 direcao = (transform.forward * moveVertical) + (transform.right * moveHorizontal);
        
        rb.velocity = new Vector3(direcao.x * velocidade, rb.velocity.y, direcao.z * velocidade);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Hazard esqueleto = collision.gameObject.GetComponent<Hazard>();
        if (esqueleto != null)
        {
            esqueleto.TomarDano();
        }
    }
}
