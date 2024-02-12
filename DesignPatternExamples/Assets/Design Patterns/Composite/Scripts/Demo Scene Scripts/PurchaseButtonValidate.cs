using UnityEngine;
using ScriptableVariable;
using UnityEngine.UI;

public class PurchaseButtonValidate : MonoBehaviour
{
    [SerializeField] private IntVariable _purchaseItemCost;
    [SerializeField] private IntVariable _currentCoins;
    [SerializeField] private Button _purchaseButton;

    private void OnEnable()
    {
        _currentCoins.OnValueChanged += ValidateButton;
        ValidateButton(_currentCoins.Value);
    }
    private void OnDisable() => _currentCoins.OnValueChanged -= ValidateButton;

    public void ValidateButton(int currentCoins)
    {
        _purchaseButton.interactable = currentCoins >= _purchaseItemCost.Value;
    }
}