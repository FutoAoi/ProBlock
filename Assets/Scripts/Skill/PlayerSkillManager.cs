using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkillManager : MonoBehaviour
{
    public Skill[] _LearnedSkills;

    private void Start()
    {
        foreach(Skill skill in _LearnedSkills)
        {
            skill.Activate(gameObject);
        }
    }
}