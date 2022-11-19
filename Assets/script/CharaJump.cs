//���w偂Ŏg�p


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharaJump : MonoBehaviour
{
    private Rigidbody2D rbody2D;

    //�W�����v��
    private float jumpForce = 150f;

    private int jumpCount = 0;

    //�E�Ɉړ�����傫��
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

        //�X�y�[�X�������ƃW�����v���E�Ɉړ�
        //�R�����g�A�E�g�͕ی�
        //�X�y�[�X���h���������h�ɐݒ肷�邱�ƂŒ������Ŕ�ׂȂ��悤�ɂ���
        if (Input.GetKeyUp(KeyCode.Space)/*&&this.jumpCount<1*/)
        {
            this.rbody2D.AddForce(transform.up * jumpForce);
            //jumpCount++;
            position.x += speed;
        }
        transform.position = position;
    }

    //�t���A�ɂӂꂽ���@�ی�
    //jumpCount�������Ȃ��̂Ō��ʂ͂Ȃ�
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Floor"))
        {
            jumpCount = 0;
        }
    }


    //�g���K�[�ɐݒ肵��Clear�ɂӂꂽ��
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "clear")
        {
            //���̃X�N���v�g�𖳌�������
            //�S�[���㑀��ł��Ȃ�
            enabled = false;

        }

    }

}
