using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMovement : MonoBehaviour
{
    public float catSpeed;
    private Rigidbody2D rb;
    private Vector2 catDirection;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        catDirection = new Vector2(0, directionY).normalized;
    }
    
    void FixedUpdate()
    {
        rb.velocity = new Vector2(0, catDirection.y * catSpeed);
    }
}
