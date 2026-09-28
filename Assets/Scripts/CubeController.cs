using UnityEngine;

public class CubeController : MonoBehaviour
{

    Material material;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        material = GetComponent<Renderer>().material;
        material.color = Color.black;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CambiarColor(int opcion)
    {
       
        switch (opcion)
        {
            case 0:
                Debug.Log("Opcion 1");
                material.color = Color.black;
            break;
            case 1:
            Debug.Log("Opcion 2");
                material.color = Color.red;
            break;
            case 2:
            Debug.Log("Opcion 3");
                material.color = Color.yellow;
            break;
        }

    }
}
