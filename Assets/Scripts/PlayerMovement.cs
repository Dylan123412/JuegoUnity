using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 10f;

    private Rigidbody rb;
    private InputSystem_Actions controles;

    private Vector2 moveInput;

    public Transform particles;
    private ParticleSystem ParticlesSystem;
    private Vector3 position;

    private int counter;

    public TextMeshProUGUI textCounter;

   void Start(){

        rb =GetComponent<Rigidbody>();

        ParticlesSystem = particles.GetComponent<ParticleSystem>();
        ParticlesSystem.Stop();

        textCounter.text = "Counter: " + counter.ToString();


    }

     void Awake()
    {
        controles = new InputSystem_Actions();

        controles.Player.Move.performed += ctx => moveInput = ctx.ReadValue<Vector2>();
        controles.Player.Move.canceled += ctx => moveInput = Vector2.zero;

    }

     void OnEnable()
    {
        controles.Enable();
    }

    void OnDisable()
    {
        controles.Disable();
    }

  

     void FixedUpdate()
    {
        Vector3 movement = new Vector3(moveInput.x, 0.0f, moveInput.y);
        rb.AddForce(movement * speed);
    }

void OnTriggerEnter(Collider other){

if(other.gameObject.CompareTag("Collectable")){


    position = other.gameObject.transform.position;
    particles.position = position;
    ParticlesSystem = particles.GetComponent<ParticleSystem>();
    ParticlesSystem.Play();
    ParticlesSystem.Stop();
    counter = counter + 1;
    textCounter.text = "Counter: " + counter.ToString();

    if(counter >= 10)
            {
                textCounter.text = "Has ganado";

            }

other.gameObject.SetActive(false);

}else {


}

}



}