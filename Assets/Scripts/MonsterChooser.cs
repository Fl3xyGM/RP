using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterChooser : MonoBehaviour {
    
    public int ChooseMonster = 0;

    public MonsterSpawn MonsterContainer;

    public void Next() {
        if(MonsterContainer.MonsterList.Count >= 0) {
            if(ChooseMonster == MonsterContainer.MonsterList.Count-1) {
                ChooseMonster = 0;
            } else {
                ChooseMonster++;
            }
        }
    }

    public void Previous() {
        if(MonsterContainer.MonsterList.Count >= 0) {
            if(ChooseMonster == 0) {
                ChooseMonster = MonsterContainer.MonsterList.Count-1;
            } else {
                ChooseMonster--;
            }
        }
    }

    void Update() {
    }
}
