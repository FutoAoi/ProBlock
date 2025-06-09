using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlockManager : MonoBehaviour
{
    [SerializeField] StageClearReward StageClearReward;
    private int _blockCount = 0;  //ブロックを数える変数
    public void AddBlock()  //ブロックの数を増やすメソッド
    {
        _blockCount++;  //ブロックの数を増やす
    }
    public void BlockDestroyed()  //ブロックの数を減らすメソッド
    {
        _blockCount--;  //ブロックの数を一つ減らす

        if( _blockCount <= 0 )  //もしブロックの数が0より少ないなら
        {
            StageClearReward.GiveReward(gameObject);
        }
    }
}
