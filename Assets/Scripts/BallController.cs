using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float _BollSpeed = 5.0f;
    Rigidbody2D _rb;
    public float _SpeedChanger = 0.000000001f;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.velocity = new Vector3(1f, 1f).normalized * _BollSpeed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Block"))
        {
            Destroy(collision.gameObject);
        }
    }
}
