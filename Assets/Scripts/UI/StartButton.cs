using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void onClickStartButton()  //ボタンを押したら
    {
        SceneManager.LoadScene("1");  //"1"のシーンをロードする
    }
}
