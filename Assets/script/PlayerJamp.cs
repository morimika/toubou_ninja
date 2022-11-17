
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJamp : MonoBehaviour
{

    //�ϐ���`
    public float flap = 100000f;
    public float scroll = 5f;
    float direction = 0f;
    Rigidbody2D rb2d;
    bool jump = false;

    // Use this for initialization
    void Start()
    {
        //�R���|�[�l���g�ǂݍ���
        rb2d = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {

        //�L�[�{�[�h����
        if (Input.GetKey(KeyCode.RightArrow))
        {
            direction = 1f;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction = -1f;
        }
        else
        {
            direction = 0f;
        }


        //�L������y����direction������scroll�̗͂�������
        rb2d.velocity = new Vector2(scroll * direction, rb2d.velocity.y);

        //�W�����v����
        if (Input.GetKeyDown("up") && !jump)
        {
            rb2d.AddForce(Vector2.up * flap);
            jump = true;
        }


    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            jump = false;
        }
    }
}
