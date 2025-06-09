using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkillManager : MonoBehaviour
{
    public Skill[] _LearnedSkills;  //覚えているスキルのリスト

    private void Start()
    {
        foreach(Skill skill in _LearnedSkills)  //リストにあるスキルを順番に
        {
            skill.Activate(gameObject);  //スキルを使用する
        }
    }

    public void LearnSkill(Skill newSkill)
    {
        var skillList = new System.Collections.Generic.List<Skill>(_LearnedSkills);
        skillList.Add(newSkill);
        _LearnedSkills = skillList.ToArray();
    }
}