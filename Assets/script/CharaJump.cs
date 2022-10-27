
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaJump : MonoBehaviour
{
    private Rigidbody2D rbody2D;

    private float jumpForce = 150f;

    private int jumpCount = 0;

    private float speed = 0.3f;


    // Start is called before the first frame update
    void Start()
    {
        rbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;

        if (Input.GetKeyUp(KeyCode.Space)/*&&this.jumpCount<1*/)
        {
            this.rbody2D.AddForce(transform.up * jumpForce);
            //jumpCount++;
            position.x += speed;
        }
        transform.position = position;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            jumpCount = 0;
        }
    }


}
