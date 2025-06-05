using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float _BollSpeed = 5.0f;  //ボールの速度の変数
    Rigidbody2D _rb;  //Rigidbodyを取得するための箱
    public float _SpeedChanger = 1.1f;  //速度変更の倍率
    public float _SpeedChangeSpan = 5f;  //速度変化の間隔
    float _time;  //速度変更してからの経過時間を測る変数
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();  //Rigidbodyを取得
        _rb.velocity = new Vector3(1f, 1f).normalized * _BollSpeed;  //ボールを斜め右に射出
    }
    private void Update()
    {
        _time += Time.deltaTime;  //経過時間を測る
        if (_time > _SpeedChangeSpan)  //もし経過時間が速度変更の間隔よりも大きくなったら
        {
            _rb.velocity = _rb.velocity * _SpeedChanger;  //ボールの速度に速度変更の倍率をかける
            _time = 0f;  //経過時間を0にする
        }
    }
}
