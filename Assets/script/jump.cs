using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jump : MonoBehaviour
{

    private Rigidbody2D rbody2D;

    //ジャンプ力
    private float jumpForce = 500f;

    //ジャンプ回数
    private int jumpCount = 0;

    //Clearタグにふれたか
    private bool isClear;

    // Start is called before the first frame update
    void Start()
    {
        //クリアでない
        isClear = false;
        rbody2D = GetComponent<Rigidbody2D>();
    }

    //トリガーに設定したClearタグにふれた時
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="clear")
        {
            //クリアした
            isClear = true;
            //4秒後にLast_changeを実行
            Invoke(nameof(Last_change),4.0f);
        }
    }

    // Update is called once per frame
    void Update()
    {

        //クリアしていてジャンプ中でないとき
        if (isClear==true&& this.jumpCount < 1)
        {
            //ジャンプする
            this.rbody2D.AddForce(transform.up * jumpForce);
            jumpCount++;
        }

    }

    //Floorに着地した時
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            //またジャンプ出来るようになる
            jumpCount = 0;
        }
    }

    private void Last_change()
    {
        //クリア画面に変わる
        //フェードにしたかったが出来なかった
        //FadeManager.Instance.LoadScene("start", 1.0f);
        SceneManager.LoadScene("Last");
    }

}
