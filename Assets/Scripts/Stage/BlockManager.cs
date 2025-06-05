using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlockManager : MonoBehaviour
{
    private int _blockCount = 0;  //ブロックを数える変数
    public void AddBlock()
    {
        _blockCount++;
    }
    public void BlockDestroyed()
    {
        _blockCount--;  //ブロックの数を一つ減らす

        if( _blockCount <= 0 )
        {
            LoadNextStage();
        }
    }
    void LoadNextStage()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene( currentSceneIndex + 1 );
    }
}
