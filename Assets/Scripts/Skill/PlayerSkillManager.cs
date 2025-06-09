using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkillManager : MonoBehaviour
{
    public Skill[] _LearnedSkills;  //�o���Ă���X�L���̃��X�g

    private void Start()
    {
        foreach(Skill skill in _LearnedSkills)  //���X�g�ɂ���X�L�������Ԃ�
        {
            skill.Activate(gameObject);  //�X�L�����g�p����
        }
    }

    public void LearnSkill(Skill newSkill)
    {
        var skillList = new System.Collections.Generic.List<Skill>(_LearnedSkills);
        skillList.Add(newSkill);
        _LearnedSkills = skillList.ToArray();
    }
}