using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsoleTextResponses : MonoBehaviour {

    public PlayerData player;

    private string Line = "-----------------------------------------------------";

    public string RedfordSkillText(float Damage, float Consumption, float RemainingAfterConsumption, string SkillName, string ConsumptionType, float MonsterHealth, string MonsterName, int MonsterNumber) {

        int TextChooser = Random.Range(1, 3);

        if(TextChooser == 1) {
            string text = $"Redford locks onto the target\nRedford uses skill: '{SkillName}' \n{Line} \nRedford deals {Damage} damage.. \nRedford uses {Consumption} {ConsumptionType}.. \nRedford has {RemainingAfterConsumption} {ConsumptionType}..\n{MonsterName} has {MonsterHealth} health left..\n{Line}";
            return text;
        } else if(TextChooser == 2) {
            string text = $"Redford rolls forward and aims at the target \nRedford uses skill: '{SkillName}' \n{Line} \nRedford deals {Damage} damage.. \nRedford uses {Consumption} {ConsumptionType}.. \nRedford has {RemainingAfterConsumption} {ConsumptionType} left..\n{MonsterName} has {MonsterHealth} health left..\n{Line}";
            return text;
        }

        return null;
    }

    public string GreatSageText() {
        return $"Redford stands still and closes his eyes\nRedford uses skill 'Great Sage'\n{Line} \nGreat Sage activates..\nRedford gains 100% critchance for 2 turns..\n{Line}";
    }

    public string MonsterText(float Damage, float Consumption, float RemainingAfterConsumption, string SkillName, string ConsumptionType, string MonsterName) {

        int TextChooser = Random.Range(1, 4);
        int Target = Random.Range(1, 3);
        string target = Target == 1 ? "Redford" : "Elerinna";
        string action = "";

        if(TextChooser == 1) {
            action = $"jumps at {target}";
        } else if(TextChooser == 2) {
            action = $"runs at {target}";
        } else if(TextChooser == 3) {
            action = $"pounces at {target}";
        }

        player.Health -= Damage;

        string text = $"{MonsterName} {action}\n{MonsterName} uses {SkillName}\n{Line}\n{MonsterName} deals {Damage} damage..\n{MonsterName} uses {Consumption} {ConsumptionType}..\n{MonsterName} has {RemainingAfterConsumption} {ConsumptionType} left..\n{target} has {player.Health} health left..\n{Line}";
        return text;
    }







}
