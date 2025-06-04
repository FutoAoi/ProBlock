using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SkillBase/PaddleScale")]
public class PaddleScale : Skill
{
    [SerializeField] Vector3 _PaddleScaleChanger = new Vector3(0.1f,0,0);
    public override void Activate(GameObject user)
    {
        user.transform.localScale += _PaddleScaleChanger;
    }
}