using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change_game : MonoBehaviour
{

    private Rigidbody2D rbody2D;

    //���s����̐Ձ@bool�^
    private bool isFloor;

    // Start is called before the first frame update
    void Start()
    {
        isFloor = false;
        rbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //���ɂӂꂽ���̔���
    private void OnCollisionEnter2D(Collision2D other)
    {
        //Floor�^�O�ɂӂꂽ��
        if (other.gameObject.CompareTag("Floor"))
        {
            Continew();
        }
    }

    //��ʑJ��
    public void Continew()
    {
        //Game�ɉ�ʑJ��
        SceneManager.LoadScene("Game");
    }
}