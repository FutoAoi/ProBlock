using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Skill : ScriptableObject
{
    [SerializeField] public string _SkillName;  //�X�L���̖��O
    [SerializeField] public string _Description;   //�X�L���̐���
    [SerializeField] public Sprite _icon;  //�X�L���̃A�C�R��

    public abstract void Activate(GameObject user);  //�X�L���̌��ʂ����钊�ۃ��\�b�h
}