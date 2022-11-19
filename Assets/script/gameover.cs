using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //トリガーに設定したgameoverタグにふれた時　画面外下に配置
    void OnTriggerEnter2D(Collider2D other)
    {   
        if(other.gameObject.tag=="gameover")
        {
            //スタート画面に戻る
            FadeManager.Instance.LoadScene("start", 1.0f);
        }

        //クリアした時フェードアウトするようにしたかったが出来なかった
        //if(other.gameObject.tag=="clear")
        //{
        //    Invoke(FadeManager.Instance.LoadScene("Last", 1.0f),3.0f);
        //}
    }
}
