using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))  //もしタグが"Ball"のオブジェクトに当たったら
        {
            Destroy(other.gameObject);  //Ballを消す
        }
    }
}
