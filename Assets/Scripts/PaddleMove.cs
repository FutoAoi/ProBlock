using UnityEngine;

public class PaddleMove : MonoBehaviour
{
    public float _PaddleSpeed = 10f;  //パドルスピードの変数

    Vector3 moveX;  //

    float x;  //水平方向の処理の値を入れる変数
    float y;  //垂直方向の処理の値を入れる変数
    float clampedX;  //
    float clampedY;

    Transform _tf;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
    void Start()
    {
        Application.targetFrameRate = 60;
        _tf = GetComponent<Transform>();
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");
        float moveX = x * _PaddleSpeed * Time.deltaTime;
        float moveY = y * _PaddleSpeed * Time.deltaTime;
        clampedX = Mathf.Clamp(_tf.position.x + moveX, -7.5f, 7.5f);
        clampedY = Mathf.Clamp(_tf.position.y + moveY, -4.5f, 4.5f);
        _tf.position = new Vector3(clampedX, clampedY, 0f);
    }
}
