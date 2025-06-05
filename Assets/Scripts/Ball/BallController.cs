using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float _BollSpeed = 5.0f;  //�{�[���̑��x�̕ϐ�
    Rigidbody2D _rb;  //Rigidbody���擾���邽�߂̔�
    public float _SpeedChanger = 1.1f;  //���x�ύX�̔{��
    public float _SpeedChangeSpan = 5f;  //���x�ω��̊Ԋu
    float _time;  //���x�ύX���Ă���̌o�ߎ��Ԃ𑪂�ϐ�
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();  //Rigidbody���擾
        _rb.velocity = new Vector3(1f, 1f).normalized * _BollSpeed;  //�{�[�����΂߉E�Ɏˏo
    }
    private void Update()
    {
        _time += Time.deltaTime;  //�o�ߎ��Ԃ𑪂�
        if (_time > _SpeedChangeSpan)  //�����o�ߎ��Ԃ����x�ύX�̊Ԋu�����傫���Ȃ�����
        {
            _rb.velocity = _rb.velocity * _SpeedChanger;  //�{�[���̑��x�ɑ��x�ύX�̔{����������
            _time = 0f;  //�o�ߎ��Ԃ�0�ɂ���
        }
    }
}
