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
        float speed = 20;
        Vector3 translation = Vector3.right * speed;
        Vector3 newPos = transform.position + translation;
        transform.position = newPos;
    }
}
