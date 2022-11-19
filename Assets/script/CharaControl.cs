//デバッグ用　プレイ時非アクティブ


using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharaControl : MonoBehaviour
{
    //移動スピード
    private float speed = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;

        //左移動
        if(Input.GetKey("left"))
        {
            position.x -= speed;
        }
        //右移動
        else if(Input.GetKey("right"))
        {
            position.x += speed;
        }

        transform.position = position;

    }

}
