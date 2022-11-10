using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingSquirrel : MonoBehaviour
{
    private float speed = 0.05f;

    private new SpriteRenderer renderer;

    private Vector2 position;

    private Vector3 targetpos;

    void Start()
    {

        position.y -= speed;

        position.x += speed;

        targetpos = transform.position;

    }

    void Update()
    {
        Vector2 position = transform.position;
        float addingSpeed = 0f;

        if (Input.GetKey("right"))
        {
            addingSpeed = speed;
        }
        else if (Input.GetKey("left"))
        {
            position.y += speed;
        }

        position.x += addingSpeed;
        transform.position = position;

        transform.position = new Vector3(Mathf.Sin(Time.time) * 10.0f + targetpos.x, targetpos.y);
    }
}
