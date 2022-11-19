
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJamp : MonoBehaviour
{

    //変数定義
    public float flap = 100f;
    public float scroll = 10f;
    float direction = 0f;
    Rigidbody2D rb2d;
    bool jump = false;

    public SpriteRenderer spriteRenderer;
    public Sprite sprite;

    // Use this for initialization
    void Start()
    {
        //コンポーネント読み込み
        rb2d = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {

        //キーボード操作
        if (Input.GetKey(KeyCode.RightArrow))
        {
            direction = 1f;
            spriteRenderer.sprite = sprite;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction = -1f;
            spriteRenderer.sprite = sprite;
        }
        else
        {
            direction = 0f;
        }


        //キャラのy軸のdirection方向にscrollの力をかける
        rb2d.velocity = new Vector2(scroll * direction, rb2d.velocity.y);

        //ジャンプ判定
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
