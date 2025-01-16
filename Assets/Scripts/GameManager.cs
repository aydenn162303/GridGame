using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI; // Add this for Image

public class GameManager : MonoBehaviour
{
    public float MoneyVar = 4f;
    public float SellValue = 0f;
    public int EquiptedPickAxeLuckMult = 1;
    public float EquiptedPickAxeSpeedMult = 1;
    public string EquiptedPickAxeName = "Hands";

    public TextMeshProUGUI Money; // Add this field
    public TextMeshProUGUI rarityText; // Add this field
    public TextMeshProUGUI itemValueText; // Add this field
    public TextMeshProUGUI diggingText; // Add this field
    public Image itemImage; // Add this field


    void Start()
    {
        UpdateMoneyText();
        HideUIElements();
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
        diggingText.gameObject.SetActive(false);
    }

    void Update()
    {
        UpdateMoneyText();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            HideNewItem();
        }
    }

    void HideNewItem()
    {
        rarityText.gameObject.SetActive(false);
        itemValueText.gameObject.SetActive(false);
        itemImage.gameObject.SetActive(false);
    }

    public void ShowNewItem()
    {
        rarityText.gameObject.SetActive(true);
        itemValueText.gameObject.SetActive(true);
        itemImage.gameObject.SetActive(true);
    }

    public void ShowDiggingText()
    {
        diggingText.gameObject.SetActive(true);
    }

    public void HideDiggingText()
    {
        diggingText.gameObject.SetActive(false);
    }

    public void ChangeSellValue(float value, string rarity)
    {
        SellValue += value;
        Debug.Log("Value: $" + SellValue.ToString("F2"));

        ShowNewItem();

        itemValueText.text = "Value: $" + value.ToString("F2");

        if (rarity == "Common")
        {
            rarityText.text = "common item";
        }
        else if (rarity == "Uncommon")
        {
            rarityText.text = "uncommon item";
        }
        else if (rarity == "Rare")
        {
            rarityText.text = "rare item";
        }
        else if (rarity == "Very Rare")
        {
            rarityText.text = "very rare item";
        }
        else if (rarity == "Insanely Rare")
        {
            rarityText.text = "insanely rare item";
        }
        else if (rarity == "Very Very Insanely Rare")
        {
            rarityText.text = "very very insanely rare item";
        }
        else
        {
            rarityText.text = "unknown?? this shouldn't happen";
        }

    }
}
