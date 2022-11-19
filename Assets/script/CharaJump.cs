//水蜘蛛で使用


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharaJump : MonoBehaviour
{
    private Rigidbody2D rbody2D;

    //ジャンプ力
    private float jumpForce = 150f;

    private int jumpCount = 0;

    //右に移動する大きさ
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

        //スペースを押すとジャンプし右に移動
        //コメントアウトは保険
        //スペースを”離した時”に設定することで長押しで飛べないようにした
        if (Input.GetKeyUp(KeyCode.Space)/*&&this.jumpCount<1*/)
        {
            this.rbody2D.AddForce(transform.up * jumpForce);
            //jumpCount++;
            position.x += speed;
        }
        transform.position = position;
    }

    //フロアにふれた時　保険
    //jumpCountが動かないので効果はない
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Floor"))
        {
            jumpCount = 0;
        }
    }


    //トリガーに設定したClearにふれた時
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "clear")
        {
            //このスクリプトを無効化する
            //ゴール後操作できない
            enabled = false;

        }

    }

}
