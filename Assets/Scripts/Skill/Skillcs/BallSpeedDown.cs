using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SkillBase/BallSpeedDown")]
public class BallSpeedDown : Skill
{
    [SerializeField] float _BallSpeedChanger = 0.9f;
    public override void Activate(GameObject user)
    {
        user.GetComponent<BallController>()._BollSpeed *= _BallSpeedChanger;
    }
}