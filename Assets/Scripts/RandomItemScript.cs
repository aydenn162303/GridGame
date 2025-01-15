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
        StartCoroutine(GenerateRandom());
    }

    IEnumerator GenerateRandom()
    {
        highestRarity = 0; // Reset highest rarity before rolling
        for (int i = 0; i < rolls; i++)
        {  
            yield return new WaitForSeconds(Random.Range(0.01f, 0.09f));
            Random.InitState(System.DateTime.Now.Millisecond);
            itemDug = Random.Range(0, 1001);
            currentRarity = 0;

            if (itemDug <= 500 && itemDug > 0)
            {
                currentRarity = 0;
            }
            else if (itemDug >= 501 && itemDug <= 700)
            {
                currentRarity = 1;
            }
            else if (itemDug >= 701 && itemDug <= 850)
            {
                currentRarity = 2;
            }
            else if (itemDug >= 851 && itemDug <= 950)
            {
                currentRarity = 3;
            }
            else if (itemDug >= 951 && itemDug <= 997)
            {
                currentRarity = 4;
            }
            else
            {
                currentRarity = 5;
            }

            if (currentRarity > highestRarity)
            {
                highestRarity = currentRarity;
            }

            yield return new WaitForSeconds(Random.Range(0.01f, 0.09f));
        }

        // Call the function based on the highest rarity rolled
        switch (highestRarity)
        {
            case 0:
                GenerateCommonItem();
                break;
            case 1:
                GenerateUncommonItem();
                break;
            case 2:
                GenerateRareItem();
                break;
            case 3:
                GenerateVeryRareItem();
                break;
            case 4:
                GenerateInsanelyRareItem();
                break;
            case 5:
                GenerateVeryVeryInsanelyRareItem();
                break;
        }
    }

    void GenerateCommonItem()
    {
        print("Common Item Generated");
    }

    void GenerateUncommonItem()
    {
        print("Uncommon Item Generated");
    }

    void GenerateRareItem()
    {
        print("Rare Item Generated");
    }

    void GenerateVeryRareItem()
    {
        print("Very Rare Item Generated");
    }

    void GenerateInsanelyRareItem()
    {
        print("Insanely Rare Item Generated");
    }

    void GenerateVeryVeryInsanelyRareItem()
    {
        print("Very Very Insanely Rare Item Generated");
    }
}
