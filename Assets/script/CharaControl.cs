//�f�o�b�O�p�@�v���C����A�N�e�B�u


using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharaControl : MonoBehaviour
{
    //�ړ��X�s�[�h
    private float speed = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;

        //���ړ�
        if(Input.GetKey("left"))
        {
            position.x -= speed;
        }
        //�E�ړ�
        else if(Input.GetKey("right"))
        {
            position.x += speed;
        }

        transform.position = position;

    }

}
