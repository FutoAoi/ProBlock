using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SkillBase/PaddleSpeed")]
public class PaddleSpeed : Skill
{
    [SerializeField] float _PaddleSpeedChanger = 1.1f;
    public override void Activate(GameObject user)
    {
        user.GetComponent<PaddleMove>()._PaddleSpeed *= _PaddleSpeedChanger;
    }
}