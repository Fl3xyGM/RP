using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BarScript : MonoBehaviour {

    [SerializeField]    
    public PlayerData playerData;
    private float OldHealth;
    private float OldStamina;
    private float OldMana;
    [SerializeField]
    public TextMeshProUGUI HealthText, StaminaText, ManaText;
    [SerializeField]
    public Slider Healthbar, Staminabar, Manabar;
    
    void Start() {
        // - Health Start
        OldHealth = playerData.Health;
        HealthText.text = $"Health: {playerData.Health}";

        // - Stamina Start
        OldStamina = playerData.CurrentStamina;
        StaminaText.text = $"Stamina: {playerData.CurrentStamina}";

        // - Mana Start
        OldMana = playerData.CurrentMana;
        ManaText.text = $"Mana: {playerData.CurrentMana}";
    }

    void Update() {
        // - Health Update
        if(OldHealth != playerData.Health) {
            Healthbar.value = playerData.Health/playerData.MaxHealth;
            HealthText.text = $"Health: {playerData.Health}";
            OldHealth = playerData.Health;
        }

        // - Stamina Update
        if(OldStamina != playerData.CurrentStamina) {
            Staminabar.value = playerData.CurrentStamina/playerData.MaxStamina;
            StaminaText.text = $"Stamina: {playerData.CurrentStamina}";
            OldStamina = playerData.CurrentStamina;
        }

        // - Mana Update
        if (OldMana != playerData.CurrentMana) {
            Manabar.value = playerData.CurrentMana/playerData.MaxMana;
            ManaText.text = $"Mana: {playerData.CurrentMana}";
            OldMana = playerData.CurrentMana;
        }
    }

}
