using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float _BollSpeed = 5.0f;
    Rigidbody2D _rb;
    public float _SpeedChanger = 1.002f;
    public float _SpeedChangeSpan = 5f;
    float _time;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.velocity = new Vector3(1f, 1f).normalized * _BollSpeed;
    }
    private void Update()
    {
        _time += Time.deltaTime;
        if (_time > _SpeedChangeSpan)
        {
            _rb.velocity = _rb.velocity * _SpeedChanger;
            _time = 0f;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Block"))
        {
            Destroy(collision.gameObject);
        }
    }
}
