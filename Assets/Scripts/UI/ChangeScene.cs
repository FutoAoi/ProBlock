using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] int index;

    private SpriteRenderer sprite;
    private Color defaultcolor;
    private bool inButton = false;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        defaultcolor = sprite.color;
    }

    private void Update()
    {
        if (inButton == true && Input.GetKeyDown(KeyCode.Space))  //スペースを押したとき
        {
            SceneManager.LoadScene(index);  //シーン変更
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Paddle"))  //パドルに触れているとき
        {
            sprite.color = Color.white;  //白色にする
            inButton = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Paddle"))
        {
            sprite.color = defaultcolor;
            inButton = false;
        }
    }
}
