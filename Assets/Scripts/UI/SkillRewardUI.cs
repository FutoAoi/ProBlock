using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine.SceneManagement;

public class SkillRewardUI : MonoBehaviour
{
    [SerializeField] GameObject _panel;
    [SerializeField] Button[] _skillButtons;
    [SerializeField] Skill[] _candidateSkills;

    private PlayerSkillManager _player;

    private void Start()
    {
        _panel.SetActive(false);
    }
    public void ShowSkillOptions(Skill[] options, PlayerSkillManager targetPlayer)
    {
        Time.timeScale = 0f;
        _panel.SetActive(true);
        _player = targetPlayer;

        for (int i = 0; i < options.Length; i++)
        {
            Skill skill = options[i];

            _skillButtons[i].GetComponentInChildren<TMP_Text>().text = skill._SkillName;
            _skillButtons[i].image.sprite = skill._icon;

            _skillButtons[i].onClick.RemoveAllListeners();
            _skillButtons[i].onClick.AddListener(() => OnSkillSelected(skill));
        }
    }

    public void OnSkillSelected(Skill selectSkill)
    {
        _player.LearnSkill(selectSkill);
        _panel.SetActive(false);
        Time.timeScale = 1f;
        LoadNextStage();
    }
    void LoadNextStage()  //次のシーンをロードするメソッド
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;  //今のシーンのインデックス番号を取得する
        SceneManager.LoadScene(currentSceneIndex + 1);  //今のインデクス番号のシーンの次のシーンを読み込む
    }
}
