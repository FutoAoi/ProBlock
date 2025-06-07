using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SkillRewardUI : MonoBehaviour
{
    [SerializeField] GameObject _panel;
    [SerializeField] Button[] _skillButtons;
    [SerializeField] Skill[] _candidateSkills;

    private PlayerSkillManager _player;

    public void ShowSkillOptions(Skill[] options, PlayerSkillManager targetPlayer)
    {
        _panel.SetActive(true);
        _player = targetPlayer;

        for (int i = 0; i < _skillButtons.Length; i++)
        {
            Skill skill = options[i];
        }
    }
}
