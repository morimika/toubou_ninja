using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jump : MonoBehaviour
{

    private Rigidbody2D rbody2D;

    //�W�����v��
    private float jumpForce = 500f;

    //�W�����v��
    private int jumpCount = 0;

    //Clear�^�O�ɂӂꂽ��
    private bool isClear;

    // Start is called before the first frame update
    void Start()
    {
        //�N���A�łȂ�
        isClear = false;
        rbody2D = GetComponent<Rigidbody2D>();
    }

    //�g���K�[�ɐݒ肵��Clear�^�O�ɂӂꂽ��
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="clear")
        {
            //�N���A����
            isClear = true;
            //4�b���Last_change�����s
            Invoke(nameof(Last_change),4.0f);
        }
    }

    // Update is called once per frame
    void Update()
    {

        //�N���A���Ă��ăW�����v���łȂ��Ƃ�
        if (isClear==true&& this.jumpCount < 1)
        {
            //�W�����v����
            this.rbody2D.AddForce(transform.up * jumpForce);
            jumpCount++;
        }

    }

    //Floor�ɒ��n������
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            //�܂��W�����v�o����悤�ɂȂ�
            jumpCount = 0;
        }
    }

    private void Last_change()
    {
        //�N���A��ʂɕς��
        //�t�F�[�h�ɂ������������o���Ȃ�����
        //FadeManager.Instance.LoadScene("start", 1.0f);
        SceneManager.LoadScene("Last");
    }

}
