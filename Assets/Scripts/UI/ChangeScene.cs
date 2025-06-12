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
        if (inButton == true && Input.GetKeyDown(KeyCode.Space))  //�X�y�[�X���������Ƃ�
        {
            SceneManager.LoadScene(index);  //�V�[���ύX
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Paddle"))  //�p�h���ɐG��Ă���Ƃ�
        {
            sprite.color = Color.white;  //���F�ɂ���
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
