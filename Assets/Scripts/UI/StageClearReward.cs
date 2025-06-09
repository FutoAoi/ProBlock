using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageClearReward : MonoBehaviour
{
    public SkillRewardUI _skillUI;
    public Skill[] _skillPool;
    public int _nunberOfOptions = 3;

    public void GiveReward(GameObject playerObject)
    {
        PlayerSkillManager manager = playerObject.GetComponent<PlayerSkillManager>();

        Skill[] options = GetRandomSkills(_nunberOfOptions);

        _skillUI.ShowSkillOptions(options, manager);
    }

    private Skill[] GetRandomSkills(int count)
    {
        Skill[] result = new Skill[count];
        System.Collections.Generic.List<Skill> pool = new System.Collections.Generic.List<Skill>(_skillPool);
        for (int i = 0; i < count; i++)
        {
            int index = Random.Range(0, pool.Count);
            result[i] = pool[index];
            pool.RemoveAt(index);
        }
        return result;
    }
}
