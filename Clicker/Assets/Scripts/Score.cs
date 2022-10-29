using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using Unity.Mathematics;
using TMPro;

public class Score : MonoBehaviour
{


    [SerializeField] Text TextOfScore;
    [SerializeField] TextMeshProUGUI textOfPlayerName;
    public int score=0;
    public int qofPlayers;
    public string userName;
    public int qOfFirstShopItem, qOfSecondShopItem, qOfThirdShopItem;
    public int priceOfFirstShopItem=10, priceOfSecondShopItem=100, priceOfThirdShopItem=1000;
    
    void Start()
    {
        qofPlayers = PlayerPrefs.GetInt("qofPlayers");
        userName = PlayerPrefs.GetString("userName");
        score = PlayerPrefs.GetInt($"{userName}_score");
        qOfFirstShopItem=PlayerPrefs.GetInt($"{userName}_qOfFirstShopItem");
        qOfSecondShopItem = PlayerPrefs.GetInt($"{userName}_qOfSecondShopItem");
        qOfThirdShopItem = PlayerPrefs.GetInt($"{userName}_qOfThirdShopItem");


        print(userName);
        print(qofPlayers);
        StartCoroutine(AutoFarmIn1Sec());
        StartCoroutine(AutoFarmIn10Sec());
    }

    void Update()
    {
        TextOfScore.text = score.ToString();
        textOfPlayerName.text = userName;

    }
    public void ClickOnChest()
    {
        score++;
        PlayerPrefs.SetInt($"{userName}_score",score);
    }


    IEnumerator AutoFarmIn10Sec()
    {
        yield return new WaitForSeconds(10);
        score = score + 1 * qOfFirstShopItem;
        PlayerPrefs.SetInt($"{userName}_score", score);
        Debug.Log(score);
        StartCoroutine(AutoFarmIn10Sec());
    }
    IEnumerator AutoFarmIn1Sec()
    {
        yield return new WaitForSeconds(1);
        score = score + 1 * qOfSecondShopItem + 10 * qOfThirdShopItem;
        PlayerPrefs.SetInt($"{userName}_score", score);
        Debug.Log(score);
        StartCoroutine(AutoFarmIn1Sec());
    }
    public void BuyFirstItem()
    {
        if (score >= math.round(priceOfFirstShopItem))
        {
            qOfFirstShopItem++;
            score = score - priceOfFirstShopItem;
            PlayerPrefs.SetInt($"{userName}_qOfFirstShopItem", qOfFirstShopItem);
            PlayerPrefs.SetInt($"{userName}_score", score);
        }
    }
    public void BuySecondItem()
    {
        if (score >= priceOfSecondShopItem)
        {
            qOfSecondShopItem++;
            score = score - priceOfSecondShopItem;
            PlayerPrefs.SetInt($"{userName}_qOfSecondShopItem", qOfSecondShopItem);
            PlayerPrefs.SetInt ($"{userName}_score", score);
        }
    }
    public void BuyThirdItem()
    {
        if (score >= priceOfThirdShopItem)
        {
            qOfThirdShopItem++;
            score = score - priceOfThirdShopItem;
            PlayerPrefs.SetInt($"{userName}_qOfThirdShopItem", qOfThirdShopItem);
            PlayerPrefs.SetInt($"{userName}_score", score);
        }
    }
}