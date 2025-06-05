using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))  //�����^�O��"Ball"�̃I�u�W�F�N�g�ɓ���������
        {
            Destroy(other.gameObject);  //Ball������
        }
    }
}
