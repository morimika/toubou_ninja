using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jump : MonoBehaviour
{

    private Rigidbody2D rbody2D;

    private float jumpForce = 350f;

    private int jumpCount = 0;

    private bool isClear;

    // Start is called before the first frame update
    void Start()
    {
        isClear = false;
        rbody2D = GetComponent<Rigidbody2D>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="clear")
        {
            isClear = true;
            Invoke(nameof(Last_change), 1.0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isClear==true&& this.jumpCount < 1)
        {
            this.rbody2D.AddForce(transform.up * jumpForce);
            jumpCount++;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            jumpCount = 0;
        }
    }

    private void Last_change()
    {
        //FadeManager.Instance.LoadScene("start", 1.0f);
        SceneManager.LoadScene("Last");
    }
}
