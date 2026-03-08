using UnityEngine;

public class create : MonoBehaviour
{
    public GameObject prefab;
    Rigidbody rb;
    public float speed = 1.0f;
    Vector3 vectle = Vector3.forward;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(prefab, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
