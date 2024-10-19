using UnityEngine;
using UnityEngine.XR;

public class DamageSpawn : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;

   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


        rb.AddForce(Vector2.up * Random.Range(100, 300) + Vector2.right * Random.Range(-200, 201)); 
        Invoke("destroy", 2);
    }

    
    void destroy()
    {
        Destroy(gameObject); 
    }
    
}
