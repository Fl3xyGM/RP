using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterStat : MonoBehaviour {
    
    private TurnManager turnManager;
    private MonsterAttacks monsterAttacks;
    private SkillsManager skill;
    private MonsterSpawn MonsterContainer;

    public int Attack;
    public int Magic;
    public int Defense;
    public int MagicDefense;
    public int Vitality;
    public int Stamina;
    public int Mana;
    public float CurrentHealth;
    public float MaxHealth;
    public float CurrentStamina;
    public float MaxStamina;
    public float CurrentMana;
    public float MaxMana;
    public string Name;
    public int Level;
    public int ListNumber;
    public int TurnNumber;
    public bool HasAttacked = false;
    private bool IsDead = false;


    void Start() {
        CurrentHealth = Random.Range(20, 30)+Vitality;
        MaxHealth = CurrentHealth;
        CurrentStamina = Random.Range(20, 25)+Stamina;
        MaxStamina = CurrentStamina;
        CurrentMana = Random.Range(20, 25)+Mana;
        MaxMana = CurrentMana;
        turnManager = GameObject.Find("TurnManager").GetComponent<TurnManager>();
        monsterAttacks = GameObject.Find("MonsterManager").GetComponent<MonsterAttacks>();
        skill = GameObject.Find("SkillsManager").GetComponent<SkillsManager>();
        MonsterContainer = GameObject.Find("MonsterManager").GetComponent<MonsterSpawn>();
    }



    void Update() {
        if(TurnNumber == turnManager.TurnCounter && HasAttacked == false && IsDead == false) {
            monsterAttacks.GoblinAttacks(ListNumber);
            HasAttacked = true;
            if(MonsterContainer.MonsterList.Count-1 >= ListNumber+1) {
                MonsterContainer.MonsterList[ListNumber+1].GetComponent<MonsterStat>().HasAttacked = false; 
            }
            skill.MoveUsed = false;
        } else if(TurnNumber == turnManager.TurnCounter && IsDead){
            MonsterContainer.MonsterList[ListNumber+1].GetComponent<MonsterStat>().HasAttacked = false; 
            turnManager.TurnCounter++;
        }
        if(CurrentHealth <= 0) {
            CurrentHealth = 0;
            IsDead = true;
        }
    }
}
