using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MonsterStatAndBars : MonoBehaviour
{
    
    [SerializeField]
    public Slider MonsterHealthSlider, MonsterStaminaSlider, MonsterManaSlider;

    [SerializeField]
    public TextMeshProUGUI StatTitle, StatText, MonsterHealthText, MonsterStaminaText, MonsterManaText;
    [SerializeField]
    public MonsterSpawn MonsterContainer;
    public MonsterChooser monsterChooser;
    private GameObject TempContainer;
    private MonsterStat TempContainer2;

    void Update() {
        TempContainer = MonsterContainer.MonsterList[monsterChooser.ChooseMonster];
        TempContainer2 = TempContainer.GetComponent<MonsterStat>();
        if(MonsterContainer.MonsterList.Count == 0) {
            MonsterHealthSlider.value = 0;
            MonsterStaminaSlider.value = 0;
            MonsterManaSlider.value = 0;
            MonsterHealthText.text = "HEALTH: 0";
            MonsterStaminaText.text = "STAMINA: 0";
            MonsterManaText.text = "MANA: 0";
            StatTitle.text = "Empty";
            StatText.text = "Attack: 0\nMagic: 0 \nDefense: 0\nMagic Defense: 0\nVitality: 0\nStamina: 0\nMana: 0\nLevel: 0";
        } else {
            MonsterHealthSlider.value = TempContainer2.CurrentHealth/TempContainer2.MaxHealth;
            MonsterStaminaSlider.value = TempContainer2.CurrentStamina/TempContainer2.MaxStamina;
            MonsterManaSlider.value = TempContainer2.CurrentMana/TempContainer2.MaxMana;
            MonsterHealthText.text = $"HEALTH: {TempContainer2.CurrentHealth}";
            MonsterStaminaText.text = $"STAMINA: {TempContainer2.CurrentStamina}";
            MonsterManaText.text = $"MANA: {TempContainer2.CurrentMana}";
            StatTitle.text = $"{TempContainer2.Name}";
            StatText.text = $"Attack: {TempContainer2.Attack} \nMagic: {TempContainer2.Magic} \nDefense: {TempContainer2.Defense} \nMagic Defense: {TempContainer2.MagicDefense} \nVitality: {TempContainer2.Vitality} \nStamina: {TempContainer2.Stamina} \nMana: {TempContainer2.Mana} \n Level: {TempContainer2.Level}";
        }
    }
}
