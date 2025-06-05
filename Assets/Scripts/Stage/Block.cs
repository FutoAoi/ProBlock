using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    private BlockManager blockManager;

    private void Start()
    {
        blockManager = FindObjectOfType<BlockManager>();
        blockManager.AddBlock();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            blockManager.BlockDestroyed();
            Destroy(gameObject);
        }
    }
}
