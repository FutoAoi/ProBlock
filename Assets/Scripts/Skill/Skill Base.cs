using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Skill : ScriptableObject
{
    [SerializeField] public string _SkillName;
    [SerializeField] public string _Description;
    [SerializeField] public Sprite _icon;

    public abstract void Activate(GameObject user);
}