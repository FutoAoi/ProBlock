using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    private BlockManager blockManager;  //BlockManager���擾���邽�߂̔�

    private void Start()
    {
        blockManager = FindObjectOfType<BlockManager>();  //BlockManager�̎擾
        blockManager.AddBlock();  //BlockManager��AddBlock���\�b�h���g�p
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ball")  //�����^�O��"Ball"�̃I�u�W�F�N�g�ɓ���������
        {
            blockManager.BlockDestroyed();  //BlockMnager��BlockDestroyed���\�b�h���g�p
            Destroy(gameObject);  //����������
        }
    }
}
