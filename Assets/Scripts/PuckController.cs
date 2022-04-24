using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuckController : MonoBehaviour
{
    public float moveSpeed = 2.0f;
    private float moveX;
    private Rigidbody2D rb;
    bool dropped = false;

 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!dropped)
        {
            moveX = Input.GetAxis("Horizontal");

            transform.Translate(transform.right * moveX * moveSpeed * Time.deltaTime);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                
                dropped = true;
                rb.simulated = true;
            }
        }
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.Instance.SpawnPuck();
        Destroy(gameObject);

    }
}
