using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    private BlockManager blockManager;  //BlockManagerを取得するための箱

    private void Start()
    {
        blockManager = FindObjectOfType<BlockManager>();  //BlockManagerの取得
        blockManager.AddBlock();  //BlockManagerのAddBlockメソッドを使用
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ball")  //もしタグが"Ball"のオブジェクトに当たったら
        {
            blockManager.BlockDestroyed();  //BlockMnagerのBlockDestroyedメソッドを使用
            Destroy(gameObject);  //自分を消す
        }
    }
}
