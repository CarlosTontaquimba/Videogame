using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    //[Range (0f , 0.9f)]
    public float velocity = 6f;
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        //Recuperamos el componente y pasamos el tipo de componente Rigidbody2D
        rb2d = GetComponent<Rigidbody2D>();
        //Indicamos una velocidad al rigidbody indicando una velocidad a la izquierda 
        rb2d.velocity = Vector2.left * velocity;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Destroyer")
        {
            Destroy(gameObject);   
        }
    }
}
