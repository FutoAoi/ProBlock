using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Skill : ScriptableObject
{
    [SerializeField] public string _SkillName;  //スキルの名前
    [SerializeField] public string _Description;   //スキルの説明
    [SerializeField] public Sprite _icon;  //スキルのアイコン

    public abstract void Activate(GameObject user);  //スキルの効果を入れる抽象メソッド
}