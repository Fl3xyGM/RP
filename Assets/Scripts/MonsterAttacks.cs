using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MonsterAttacks : MonoBehaviour {

    private MonsterStat Monster;
    public TextMeshProUGUI Console;
    public PlayerData player;
    public ConsoleTextResponses Text;
    public MonsterSpawn MonsterContainer;
    
    public void GoblinAttacks(int ListNumber) {
        Monster = MonsterContainer.MonsterList[ListNumber].GetComponent<MonsterStat>();

        int MoveChooser = Random.Range(1,4);

        if(MoveChooser == 1) {
            string Name = "Stab";
            float Damage = Monster.Attack;
            string Type = "stamina";
            float StaminaConsumption = 8;
            Monster.CurrentStamina -= StaminaConsumption;
            Console.text = Text.MonsterText(NoDecimals(Damage, player.Defense), StaminaConsumption, Monster.CurrentStamina, Name, Type, Monster.Name);
        }
        if(MoveChooser == 2) {
            string Name = "Slash";
            float Damage = Monster.Attack;
            string Type = "stamina";
            float StaminaConsumption = 8;
            Monster.CurrentStamina -= StaminaConsumption;
            Console.text = Console.text = Text.MonsterText(NoDecimals(Damage, player.Defense), StaminaConsumption, Monster.CurrentStamina, Name, Type, Monster.Name);
        }
        if(MoveChooser == 3) {
            string Name = "Double Slash";
            float Damage = Monster.Attack * 1.5f;
            string Type = "stamina";
            float StaminaConsumption = 8;
            Monster.CurrentStamina -= StaminaConsumption;
            Console.text = Console.text = Text.MonsterText(NoDecimals(Damage, player.Defense), StaminaConsumption, Monster.CurrentStamina, Name, Type, Monster.Name);
        }
        
    }


    IEnumerator NexTurn() {

        

        return null;
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









}
