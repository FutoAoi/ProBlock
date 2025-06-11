using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] int index;

    private SpriteRenderer sprite;
    private Color defocolor;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        defocolor = sprite.color;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Paddle"))
        {
            sprite.color = Color.white;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(index);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Paddle"))
        {
            sprite.color = defocolor;
        }
    }
}
