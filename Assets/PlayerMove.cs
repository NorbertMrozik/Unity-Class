using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 10f;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical= Input.GetAxisRaw("Vertical");

        Vector3 playerMovement = new Vector3(moveHorizontal, 0, moveVertical);

        rb.AddForce(playerMovement * speed);
    }
}
