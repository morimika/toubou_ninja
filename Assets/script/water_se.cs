using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water_se : MonoBehaviour
{

    public AudioClip sound1;
    AudioSource audioSource;

    void Start()
    {
        //Componentを取得
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // スペースキーを離した時
        if (Input.GetKeyUp(KeyCode.Space))
        {
            //SEを鳴らす
            audioSource.PlayOneShot(sound1);
        }
    }

    //連打することでマシンガンのような音になってしまう
}