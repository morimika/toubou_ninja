using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change_game : MonoBehaviour
{

    private Rigidbody2D rbody2D;

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
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            Continew();
        }
    }

    //‰æ–Ê‘JˆÚ
    public void Continew()
    {
        SceneManager.LoadScene("Game");
    }
}