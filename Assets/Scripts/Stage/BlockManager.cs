using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlockManager : MonoBehaviour
{
    private int _blockCount = 0;  //�u���b�N�𐔂���ϐ�
    public void AddBlock()
    {
        _blockCount++;
    }
    public void BlockDestroyed()
    {
        _blockCount--;  //�u���b�N�̐�������炷

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
