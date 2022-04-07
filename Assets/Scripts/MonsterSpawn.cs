using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawn : MonoBehaviour {

    public TurnManager turnManager;
    public GameObject MonsterPrefab;

    public List<GameObject> MonsterList = new List<GameObject>();

    void Start() {
        for(int i = 0; i < 4; i++) {
            Goblin();
        }
    }

    private void Goblin() {
        GameObject Goblin = Instantiate(MonsterPrefab);
        MonsterList.Add(Goblin);
        MonsterStat StatChange = MonsterList[MonsterList.Count-1].GetComponent<MonsterStat>();
        StatChange.Attack = Random.Range(3, 6);
        StatChange.Magic = 0;
        StatChange.Defense = Random.Range(4, 8);
        StatChange.MagicDefense = 0;
        StatChange.Vitality = Random.Range(3, 6);
        StatChange.Stamina = Random.Range(3, 6);
        StatChange.Mana = 0;
        StatChange.Level = LevelCalc(StatChange);
        StatChange.ListNumber = MonsterList.Count-1;
        StatChange.TurnNumber = turnManager.TurnCounterMax;
        StatChange.Name = $"Goblin[{MonsterList.Count}]";
        turnManager.TurnCounterMax++;
    }

    private int LevelCalc(MonsterStat StatChanges) {
        float Calc = StatChanges.Attack + StatChanges.Magic + StatChanges.Defense + StatChanges.MagicDefense + StatChanges.Vitality + StatChanges.Stamina + StatChanges.Mana;

        if(Calc < 17) {
            return 1;
        } else if(Calc >= 17 && Calc < 22) {
            return 2;
        } else if(Calc >= 22 && Calc < 27) {
            return 3;
        } else if(Calc >= 27 && Calc < 32) {
            return 4;
        }
        return 0;

    }


}
