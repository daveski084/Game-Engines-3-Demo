using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rb;

    [SerializeField]
    float speed = 6;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movmentVector = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        movmentVector *= speed;
        rb.velocity = movmentVector;
    }
}
