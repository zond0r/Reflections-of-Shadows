using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CharControls : MonoBehaviour
{
    float epsilon = 0.000001f;
    float limit = 0f;

    public float speed = 0f;
    public float timer = 0f;

    public Vector2 pos0 = new Vector2(0f, 0f);
    public Vector2 move = new Vector2(0f, 0f);
    public Vector2 max = new Vector2(21f, 21f);

    void Start()
    {
        transform.position = new Vector3(-pos0.x, 0.501f, -pos0.y);
    }

    void Update()
    {
        if (move.x > 10) move.x = 10;
        else if(move.x < -10) move.x = -10;

        if (move.y > 10) move.y = 10;
        else if(move.y < -10) move.y = -10;

        if (speed > 10) speed = 10;
        else if (speed < 0) speed = 0;

        if (timer < 0) timer = 0;
        if (timer != 0) limit += Time.deltaTime;
        else limit = 0;

        if (limit <= timer)
            transform.Translate(move.x * -Time.deltaTime * speed, 0f, move.y * -Time.deltaTime * speed);

        else if (timer + 1f <= limit) limit = 0; 

        if(Math.Abs(transform.position.x) > max.x || Math.Abs(transform.position.z) > max.y)
            transform.position = new Vector3(-pos0.x, 0.501f, -pos0.y);
    }
}
