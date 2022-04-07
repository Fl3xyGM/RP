using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SkillsManager : MonoBehaviour {
    
public PlayerData playerData;

public TextMeshProUGUI Console;

public MonsterSpawn MonsterContainer;
public MonsterChooser chooseMonster;
public TurnManager turnManager;

public ConsoleTextResponses Text;

public Button Skill1, Skill2, Skill3, Skill4;

public bool MoveUsed = false;
private bool YourTurn = true;

private MonsterStat monsterStat;

    public void RedfordSkill1() {
        float Damage = playerData.Attack;
        float StaminaConsumption = 8;
        string Name = "Normal Arrow";
        string Type = "stamina";
        playerData.CurrentStamina -= StaminaConsumption;
        monsterStat.CurrentHealth -= NoDecimals(Damage, monsterStat.Defense);
        Console.text = Text.RedfordSkillText(NoDecimals(Damage, 0), StaminaConsumption, playerData.CurrentStamina, Name, Type, monsterStat.CurrentHealth, monsterStat.Name, chooseMonster.ChooseMonster);
        MoveUsed = true;
        MonsterContainer.MonsterList[0].GetComponent<MonsterStat>().HasAttacked = false;
    }

    public void RedfordSkill2() {
        float Damage = playerData.Magic * 1.25f;
        float ManaConsumption = 10;
        string Name = "Magic Arrow";
        string Type = "mana";
        playerData.CurrentMana -= ManaConsumption;
        monsterStat.CurrentHealth -= NoDecimals(Damage, monsterStat.MagicDefense);
        Console.text = Text.RedfordSkillText(NoDecimals(Damage, 0), ManaConsumption, playerData.CurrentMana, Name, Type, monsterStat.CurrentHealth, monsterStat.Name, chooseMonster.ChooseMonster);
        MoveUsed = true;
        MonsterContainer.MonsterList[0].GetComponent<MonsterStat>().HasAttacked = false;
    }

    public void RedfordSkill3() {
        float Damage = playerData.Magic * 1.80f;
        float ManaConsumption = 14f;
        string Name = "Triple Magic Arrow";
        string Type = "mana";
        playerData.CurrentMana -= ManaConsumption;
        monsterStat.CurrentHealth -= NoDecimals(Damage, monsterStat.MagicDefense);
        Console.text = Text.RedfordSkillText(NoDecimals(Damage, 0), ManaConsumption, playerData.CurrentMana, Name, Type, monsterStat.CurrentHealth, monsterStat.Name, chooseMonster.ChooseMonster);
        MoveUsed = true;
        MonsterContainer.MonsterList[0].GetComponent<MonsterStat>().HasAttacked = false;
    }

    public void RedfordSkill4() {
        playerData.CritChance = 100;
        float ManaConsumption = 20;
        playerData.CurrentMana -= ManaConsumption;
        Console.text = Text.GreatSageText();
        MoveUsed = true;
        MonsterContainer.MonsterList[0].GetComponent<MonsterStat>().HasAttacked = false;
    }

    private float NoDecimals(float Damage, float Defense) {

        float DefenseMult = 1-Defense/200;
        float DamageTaken = Damage*DefenseMult;

        if(DamageTaken % 1 != 0) {
            if(DamageTaken % 1 < 0.5) {
                DamageTaken = Mathf.Floor(DamageTaken);
            } else {
                DamageTaken = Mathf.Ceil(DamageTaken);
            }
        }
        return DamageTaken;
    }


    void Update() {

        monsterStat = MonsterContainer.MonsterList[chooseMonster.ChooseMonster].GetComponent<MonsterStat>();

        if(turnManager.TurnCounter == 0) {
            YourTurn = true;
        } else {
            YourTurn = false;
        }

        if(playerData.CurrentStamina - 8 < 0) {
            Skill1.interactable = false;
        } else {
            Skill1.interactable = true;
        }

        if(playerData.CurrentMana - 10 < 0) {
            Skill2.interactable = false;

        } else {
            Skill2.interactable = true;
        }

        if(playerData.CurrentMana - 14.4 < 0) {
            Skill3.interactable = false;
        } else {
            Skill3.interactable = true;
        }

        if(playerData.CurrentMana - 20 < 0) {
            Skill4.interactable = false;
        } else {
            Skill4.interactable = true;
        }

        if(YourTurn == false || MoveUsed == true) {
            Skill1.interactable = false;
            Skill2.interactable = false;
            Skill3.interactable = false;
            Skill4.interactable = false;
        } else {
            Skill1.interactable = true;
            Skill2.interactable = true;
            Skill3.interactable = true;
            Skill4.interactable = true;
        }

    }











}
