
using UnityEngine;

public class ObjectRotation : MonoBehaviour
{
    


    private void Update()
    {
        transform.Rotate( new Vector3(45, 45, 45) * Time.deltaTime  );
    }
}
