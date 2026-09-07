using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 10f;

    private Rigidbody rb;
    private InputSystem_Actions inputActions;

    private Vector2 movement;

    public Transform particles;
    private ParticleSystem ParticlesSystem;
    private Vector3 position;

    private void start(){
        ParticlesSystem = particles.GetComponent<ParticleSystem>();
        ParticlesSystem.Stop();


    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        inputActions = new InputSystem_Actions();
    }

    private void OnEnable()
    {
        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }

    private void Update()
    {
        movement = inputActions.Player.Move.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        Vector3 direction = new Vector3(
            movement.x,
            0f,
            movement.y
        );

        rb.MovePosition(
            rb.position + direction * speed * Time.fixedDeltaTime
        );
    }

void OnTriggerEnter(Collider other){

if(other.gameObject.CompareTag("Collectable")){


    position = other.gameObject.transform.position;
    particles.position = position;
    ParticlesSystem = particles.GetComponent<ParticleSystem>();
    ParticlesSystem.Play();

other.gameObject.SetActive(false);

}else {


}

}



}