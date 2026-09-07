
using UnityEngine;

public class ObjectRotation : MonoBehaviour
{
    [SerializeField] private float velocidadX = 100f;
    [SerializeField] private float velocidadY = 100f;
    [SerializeField] private float velocidadZ = 100f;

    private void Update()
    {
        transform.Rotate(
            velocidadX * Time.deltaTime,
            velocidadY * Time.deltaTime,
            velocidadZ * Time.deltaTime
        );
    }
}
