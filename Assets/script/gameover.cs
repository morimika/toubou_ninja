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

    //�g���K�[�ɐݒ肵��gameover�^�O�ɂӂꂽ���@��ʊO���ɔz�u
    void OnTriggerEnter2D(Collider2D other)
    {   
        if(other.gameObject.tag=="gameover")
        {
            //�X�^�[�g��ʂɖ߂�
            FadeManager.Instance.LoadScene("start", 1.0f);
        }

        //�N���A�������t�F�[�h�A�E�g����悤�ɂ������������o���Ȃ�����
        //if(other.gameObject.tag=="clear")
        //{
        //    Invoke(FadeManager.Instance.LoadScene("Last", 1.0f),3.0f);
        //}
    }
}
