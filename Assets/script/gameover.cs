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

    void OnTriggerEnter2D(Collider2D other)
    {   
        if(other.gameObject.tag=="gameover")
        {
            FadeManager.Instance.LoadScene("start", 1.0f);
        }

        //if(other.gameObject.tag=="clear")
        //{
        //    Invoke(FadeManager.Instance.LoadScene("Last", 1.0f),3.0f);
        //}
    }
}
