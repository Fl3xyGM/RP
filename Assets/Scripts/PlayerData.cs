using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour {

    public int Attack = 3;
    public int Magic = 10;
    public int Defense = 2;
    public int MagicDefense = 2;
    public int Vitality = 2;
    public int Stamina = 2;
    public int Mana = 4;
    public int XP = 0;
    public int Level = 1;
    public float Health;
    public float MaxHealth;
    public float CurrentStamina;
    public float MaxStamina;
    public float CurrentMana;
    public float MaxMana;
    public float CritChance = 0;
    public int TurnNumber = 0;

    void Start() {
        float Temp = Mathf.Floor(100 + Vitality*1.2f);
        Health = Temp;
        MaxHealth = Health;
        CurrentStamina = 20 + Stamina;
        MaxStamina = CurrentStamina;
        CurrentMana = 20 + Mana;
        MaxMana = CurrentMana;
    }
    
}
