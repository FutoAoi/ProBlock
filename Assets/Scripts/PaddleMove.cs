using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMove : MonoBehaviour
{
    public float _PaddleSpeed = 10f;

    Vector3 _move;

    float x;
    float clampedx;

    Transform _tf;
    void Start()
    {
        Application.targetFrameRate = 60;
        _tf = GetComponent<Transform>();
    }

    void Update()
    {
        x = Input.GetAxis("Horizontal");
        _move = new Vector3(x * _PaddleSpeed * Time.deltaTime, 0f, 0f);
        _tf.position += _move;
        clampedx = Mathf.Clamp(_tf.position.x, -7.5f, 7.5f);
        _tf.position = new Vector3(clampedx,_tf.position.y,0f);
    }
}
