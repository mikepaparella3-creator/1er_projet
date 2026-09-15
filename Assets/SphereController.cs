using UnityEngine;

public class SphereController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 translation = Vector3.right * 10;
        Vector3 newPos = transform.position + translation;
        transform.position = newPos;
    }
}
