using UnityEngine;

public class PaddleMove : MonoBehaviour
{
    public float _PaddleSpeed = 10f;  //�p�h���X�s�[�h�̕ϐ�

    Vector3 moveX;  //

    float x;  //���������̏����̒l������ϐ�
    float y;  //���������̏����̒l������ϐ�
    float clampedX;  //
    float clampedY;

    Transform _tf;
    void Start()
    {
        Application.targetFrameRate = 60;
        _tf = GetComponent<Transform>();
    }

    void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");
        float moveX = x * _PaddleSpeed * Time.deltaTime;
        float moveY = y * _PaddleSpeed * Time.deltaTime;
        clampedX = Mathf.Clamp(_tf.position.x + moveX, -7.5f, 7.5f);
        clampedY = Mathf.Clamp(_tf.position.y + moveY, -4f, 4f);
        _tf.position = new Vector3(clampedX, clampedY, 0f);
    }
}
