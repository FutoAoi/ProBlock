using UnityEngine;

public class PaddleSpeed : MonoBehaviour
{
    [SerializeField] PaddleMove paddleMove;
    [SerializeField] float paddleSpeedChanger = 1.0f;

    private SpriteRenderer spriteRenderer;

    private bool inButton = false;

    private Color defaultcolor;

    private void Start()
    {
        paddleMove = FindAnyObjectByType<PaddleMove>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        defaultcolor = spriteRenderer.color;
    }
    private void Update()
    {
        if (inButton == true && Input.GetKeyDown(KeyCode.Space))
        {
            paddleMove._PaddleSpeed += paddleSpeedChanger;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Paddle"))
        {
            spriteRenderer.color = Color.white;
            inButton = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Paddle"))
        {
            spriteRenderer.color = defaultcolor;
            inButton = false;
        }
    }
}
