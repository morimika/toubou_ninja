using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water_se : MonoBehaviour
{

    public AudioClip sound1;
    AudioSource audioSource;

    void Start()
    {
        //Component���擾
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // �X�y�[�X�L�[
        if (Input.GetKeyUp(KeyCode.Space))
        {
            //��(sound1)��炷
            audioSource.PlayOneShot(sound1);
        }
    }
}