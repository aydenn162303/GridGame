using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomItemScript : MonoBehaviour
{
    private GameObject GameManager;
    private int rolls = 1;
    private int itemDug = 0;
    private int highestRarity = 0;
    private int currentRarity;
    //0 = common
    //1 = uncommon
    //2 = rare
    //3 = very rare
    //4 = insanely rare
    //5 = very very insanely rare

    void Start()
    {
        GameManager = GameObject.Find("GameManager");
        if (GameManager == null)
        {
            Debug.LogError("GameManager not found in the scene.");
            return;
        }
        GameManager.GetComponent<GameManager>().ShowDiggingText();
        rolls = GameManager.GetComponent<GameManager>().EquiptedPickAxeLuckMult;
        StartCoroutine(ToggleVisibility());
    }

    IEnumerator ToggleVisibility()
    {
        for (int i = 0; i < 8; i++)
        {
            GameManager.GetComponent<GameManager>().ShowDiggingText();
            yield return new WaitForSeconds(1f);
            GameManager.GetComponent<GameManager>().HideDiggingText();
            yield return new WaitForSeconds(0.2f);
        }
        yield return StartCoroutine(GenerateRandom());
        Destroy(gameObject);
    }

    IEnumerator GenerateRandom()
    {
        highestRarity = 0; // Reset highest rarity before rolling
        for (int i = 0; i < rolls; i++)
        {  
            Random.InitState((int)GameManager.GetComponent<GameManager>().constantRandomSeed);
            print("Random Seed: " + GameManager.GetComponent<GameManager>().constantRandomSeed);
            itemDug = Random.Range(0, 1001);
            currentRarity = 0;

            if (itemDug <= 700 && itemDug > 0) // 70% chance for common items
            {
                currentRarity = 0;
            }
            else if (itemDug >= 701 && itemDug <= 900) // 20% chance for uncommon items
            {
                currentRarity = 1;
            }
            else if (itemDug >= 901 && itemDug <= 960) // 6% chance for rare items
            {
                currentRarity = 2;
            }
            else if (itemDug >= 961 && itemDug <= 990) // 3% chance for very rare items
            {
                currentRarity = 3;
            }
            else if (itemDug >= 991 && itemDug <= 999) // 1% chance for insanely rare items
            {
                currentRarity = 4;
            }
            else // 0.1% chance for very very insanely rare items
            {
                currentRarity = 5;
            }

            if (currentRarity > highestRarity)
            {
                highestRarity = currentRarity;
            }

            yield return new WaitForSeconds(Random.Range(0.01f, 0.03f));
        }

        // Call the function based on the highest rarity rolled
        switch (highestRarity)
        {
            case 0:
                GenerateCommonItem();
                GameManager.GetComponent<GameManager>().HideDiggingText();
                break;
            case 1:
                GenerateUncommonItem();
                GameManager.GetComponent<GameManager>().HideDiggingText();
                break;
            case 2:
                GenerateRareItem();
                GameManager.GetComponent<GameManager>().HideDiggingText();
                break;
            case 3:
                GenerateVeryRareItem();
                GameManager.GetComponent<GameManager>().HideDiggingText();
                break;
            case 4:
                GenerateInsanelyRareItem();
                GameManager.GetComponent<GameManager>().HideDiggingText();
                break;
            case 5:
                GenerateVeryVeryInsanelyRareItem();
                GameManager.GetComponent<GameManager>().HideDiggingText();
                break;
        }
    }

    void GenerateCommonItem()
    {
        itemDug = Random.Range(1, 11);

        switch(itemDug)
        {
            case 1:
                print("Common Item 1 Generated");
                GameManager.GetComponent<GameManager>().ChangeSellValue(15f, "Common");
                break;
            case 2:
                print("Common Item 2 Generated");
                GameManager.GetComponent<GameManager>().ChangeSellValue(10f, "Common");
                break;
            case 3:
                print("Common Item 3 Generated");
                GameManager.GetComponent<GameManager>().ChangeSellValue(12f, "Common");
                break;
            case 4:
                print("Common Item 4 Generated");
                GameManager.GetComponent<GameManager>().ChangeSellValue(8f, "Common");
                break;
            case 5:
                print("Common Item 5 Generated");
                GameManager.GetComponent<GameManager>().ChangeSellValue(14f, "Common");
                break;
            case 6:
                print("Common Item 6 Generated");
                GameManager.GetComponent<GameManager>().ChangeSellValue(9f, "Common");
                break;
            case 7:
                print("Common Item 7 Generated");
                GameManager.GetComponent<GameManager>().ChangeSellValue(11f, "Common");
                break;
            case 8:
                print("Common Item 8 Generated");
                GameManager.GetComponent<GameManager>().ChangeSellValue(13f, "Common");
                break;
            case 9:
                print("Common Item 9 Generated");
                GameManager.GetComponent<GameManager>().ChangeSellValue(7f, "Common");
                break;
            case 10:
                print("Common Item 10 Generated");
                GameManager.GetComponent<GameManager>().ChangeSellValue(6f, "Common");
                break;
        }
    }

    void GenerateUncommonItem()
    {
        itemDug = Random.Range(1, 11);

        switch(itemDug)
        {
            case 1:
                print("Uncommon Item 1 Generated");
                GameManager.GetComponent<GameManager>().ChangeSellValue(30f, "Uncommon");
                break;
            case 2:
                print("Uncommon Item 2 Generated");
                GameManager.GetComponent<GameManager>().ChangeSellValue(20f, "Uncommon");
                break;
            case 3:
                print("Uncommon Item 3 Generated");
                GameManager.GetComponent<GameManager>().ChangeSellValue(24f, "Uncommon");
                break;
            case 4:
                print("Uncommon Item 4 Generated");
                GameManager.GetComponent<GameManager>().ChangeSellValue(16f, "Uncommon");
                break;
            case 5:
                print("Uncommon Item 5 Generated");
                GameManager.GetComponent<GameManager>().ChangeSellValue(28f, "Uncommon");
                break;
            case 6:
                print("Uncommon Item 6 Generated");
                GameManager.GetComponent<GameManager>().ChangeSellValue(18f, "Uncommon");
                break;
            case 7:
                print("Uncommon Item 7 Generated");
                GameManager.GetComponent<GameManager>().ChangeSellValue(22f, "Uncommon");
                break;
            case 8:
                print("Uncommon Item 8 Generated");
                GameManager.GetComponent<GameManager>().ChangeSellValue(26f, "Uncommon");
                break;
            case 9:
                print("Uncommon Item 9 Generated");
                GameManager.GetComponent<GameManager>().ChangeSellValue(14f, "Uncommon");
                break;
            case 10:
                print("Uncommon Item 10 Generated");
                GameManager.GetComponent<GameManager>().ChangeSellValue(12f, "Uncommon");
                break;
        }
    }

    void GenerateRareItem()
    {
        itemDug = Random.Range(1, 6);

        switch(itemDug)
        {
            case 1:
                print("Rare Item 1 Generated");
                GameManager.GetComponent<GameManager>().ChangeSellValue(90f, "Rare");
                break;
            case 2:
                print("Rare Item 2 Generated");
                GameManager.GetComponent<GameManager>().ChangeSellValue(70f, "Rare");
                break;
            case 3:
                print("Rare Item 3 Generated");
                GameManager.GetComponent<GameManager>().ChangeSellValue(84f, "Rare");
                break;
            case 4:
                print("Rare Item 4 Generated");
                GameManager.GetComponent<GameManager>().ChangeSellValue(56f, "Rare");
                break;
            case 5:
                print("Rare Item 5 Generated");
                GameManager.GetComponent<GameManager>().ChangeSellValue(112f, "Rare");
                break;
        }
    }

    void GenerateVeryRareItem()
    {
        itemDug = Random.Range(1, 6);

        switch(itemDug)
        {
            case 1:
                print("Very Rare Item 1 Generated");
                GameManager.GetComponent<GameManager>().ChangeSellValue(200f, "Very Rare");
                break;
            case 2:
                print("Very Rare Item 2 Generated");
                GameManager.GetComponent<GameManager>().ChangeSellValue(250f, "Very Rare");
                break;
            case 3:
                print("Very Rare Item 3 Generated");
                GameManager.GetComponent<GameManager>().ChangeSellValue(300f, "Very Rare");
                break;
            case 4:
                print("Very Rare Item 4 Generated");
                GameManager.GetComponent<GameManager>().ChangeSellValue(350f, "Very Rare");
                break;
            case 5:
                print("Very Rare Item 5 Generated");
                GameManager.GetComponent<GameManager>().ChangeSellValue(400f, "Very Rare");
                break;
        }
    }

    void GenerateInsanelyRareItem()
    {
        itemDug = Random.Range(1, 6);

        switch(itemDug)
        {
            case 1:
                print("Insanely Rare Item 1 Generated");
                GameManager.GetComponent<GameManager>().ChangeSellValue(450f, "Insanely Rare");
                break;
            case 2:
                print("Insanely Rare Item 2 Generated");
                GameManager.GetComponent<GameManager>().ChangeSellValue(470f, "Insanely Rare");
                break;
            case 3:
                print("Insanely Rare Item 3 Generated");
                GameManager.GetComponent<GameManager>().ChangeSellValue(420f, "Insanely Rare");
                break;
            case 4:
                print("Insanely Rare Item 4 Generated");
                GameManager.GetComponent<GameManager>().ChangeSellValue(480f, "Insanely Rare");
                break;
            case 5:
                print("Insanely Rare Item 5 Generated");
                GameManager.GetComponent<GameManager>().ChangeSellValue(460f, "Insanely Rare");
                break;
        }
    }

    void GenerateVeryVeryInsanelyRareItem()
    {
        itemDug = Random.Range(1, 6);

        switch(itemDug)
        {
            case 1:
                print("Very Very Insanely Rare Item 1 Generated");
                GameManager.GetComponent<GameManager>().ChangeSellValue(900f, "Very Very Insanely Rare");
                break;
            case 2:
                print("Very Very Insanely Rare Item 2 Generated");
                GameManager.GetComponent<GameManager>().ChangeSellValue(870f, "Very Very Insanely Rare");
                break;
            case 3:
                print("Very Very Insanely Rare Item 3 Generated");
                GameManager.GetComponent<GameManager>().ChangeSellValue(840f, "Very Very Insanely Rare");
                break;
            case 4:
                print("Very Very Insanely Rare Item 4 Generated");
                GameManager.GetComponent<GameManager>().ChangeSellValue(856f, "Very Very Insanely Rare");
                break;
            case 5:
                print("Very Very Insanely Rare Item 5 Generated");
                GameManager.GetComponent<GameManager>().ChangeSellValue(812f, "Very Very Insanely Rare");
                break;
        }
    }
}
