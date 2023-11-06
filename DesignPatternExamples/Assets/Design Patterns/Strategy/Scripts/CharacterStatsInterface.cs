using TMPro;
using UnityEngine;
using System.Collections.Generic;

public class CharacterStatsInterface : MonoBehaviour
{
    [SerializeField] private GameObject _warriorInterfaceObject;
    [SerializeField] private GameObject _ninjaInterfaceObject;
    [SerializeField] private GameObject _archerInterfaceObject;
    [SerializeField] private TMP_Text _descriptionText;
    [SerializeField] private TMP_Text _healthText;
    [SerializeField] private TMP_Text _attackDamageText;
    [SerializeField] private TMP_Text _speedText;
    [SerializeField] private TMP_Text _armorText;
    private CharacterStatsContext _characterStatsContext = new();
    private List<GameObject> _characterObjects = new List<GameObject>();

    private void OnEnable()
    {
        if (_characterObjects.Count > 0)
            return;
        _characterObjects.Add(_warriorInterfaceObject);
        _characterObjects.Add(_ninjaInterfaceObject);
        _characterObjects.Add(_archerInterfaceObject);
    }

    public void SetStrategy(IStrategy strategy) => _characterStatsContext.SetStrategy(strategy);

    public void SetWarriorStrategy()
    {
        _characterStatsContext.SetStrategy(new ConcreteWarriorStrategy());

        UpdateCharacterInterface();
        EnableChooseCharacterObject(_warriorInterfaceObject);
    }

    public void SetNinjaStrategy()
    {
        _characterStatsContext.SetStrategy(new ConcreteNinjaStrategy());

        UpdateCharacterInterface();
        EnableChooseCharacterObject(_ninjaInterfaceObject);
    }

    public void SetArcherStrategy()
    {
        _characterStatsContext.SetStrategy(new ConcreteArcherStrategy());

        UpdateCharacterInterface();
        EnableChooseCharacterObject(_archerInterfaceObject);
    }

    public void EnableChooseCharacterObject(GameObject chooseCharacterObject)
    {
        foreach (GameObject characterObject in _characterObjects)
        {
            characterObject.SetActive(false);
        }

        chooseCharacterObject.SetActive(true);
    }

    public void UpdateCharacterInterface()
    {
        CharacterStats characterStats = _characterStatsContext.GetCharacterStats()!;

        _descriptionText.text = characterStats._description;
        _healthText.text = characterStats._health.ToString();
        _attackDamageText.text = characterStats._attackDamage.ToString();
        _speedText.text = characterStats._attackSpeed.ToString();
        _armorText.text = characterStats._armor.ToString();
    }
}