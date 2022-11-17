
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class whiteout : MonoBehaviour
{

    GameObject me; // �����̃I�u�W�F�N�g�擾�p�ϐ�
    public float fadeStart = 1f; // �t�F�[�h�J�n����
    public bool fadeIn = true; // true�̏ꍇ�̓t�F�[�h�C��
    public float fadeSpeed = 1f; // �t�F�[�h���x�w��


    // Start is called before the first frame update
    void Start()
    {
        me = this.gameObject; // �����̃I�u�W�F�N�g�擾
    }

    // Update is called once per frame
    void Update()
    {
        if (fadeStart > 0f)
        {
            fadeStart -= Time.deltaTime;
        }
        else
        {
            if (fadeIn)
            {
                fadeInFunc();
            }
        }
    }

    void fadeInFunc()
    {
        if (me.GetComponent<Image>().color.a < 255)
        {
            UnityEngine.Color tmp = me.GetComponent<Image>().color;
            tmp.a = tmp.a + (Time.deltaTime * fadeSpeed);
            me.GetComponent<Image>().color = tmp;
        }
    }
}