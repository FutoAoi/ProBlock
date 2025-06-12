using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScale : MonoBehaviour
{
    [SerializeField] GameObject paddle;
    [SerializeField] float paddleScaleChanger = 0.1f;

    private SpriteRenderer spriteRenderer;

    private Color defaultcolor;

    private bool inButton = false;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        paddle = GameObject.Find("Paddle");
        defaultcolor = spriteRenderer.color;
    }

    // Update is called once per frame
    void Update()
    {
        if (inButton = true && Input.GetKeyDown(KeyCode.Space))
        {
            paddle.transform.localScale += new Vector3(paddleScaleChanger, 0f, 0f);
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
