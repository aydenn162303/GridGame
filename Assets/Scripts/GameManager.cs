using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI; // Add this for Image

public class GameManager : MonoBehaviour
{
    public float MoneyVar = 4;
    public float EquiptedPickAxeLuckMult = 1;
    public float EquiptedPickAxeSpeedMult = 1;
    public string EquiptedPickAxeName = "Hands";

    public TextMeshProUGUI Money; // Add this field
    public TextMeshProUGUI rarityText; // Add this field
    public TextMeshProUGUI itemValueText; // Add this field
    public Image itemImage; // Add this field

    void Start()
    {
        UpdateMoneyText();
        HideUIElements();
    }

    void Update()
    {
        UpdateMoneyText();
    }

    void UpdateMoneyText()
    {
        Money.text = "Money: $" + MoneyVar.ToString("F2");
    }

    void HideUIElements()
    {
        rarityText.gameObject.SetActive(false);
        itemValueText.gameObject.SetActive(false);
        itemImage.gameObject.SetActive(false);
    }
}
