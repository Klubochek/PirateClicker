using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopScript : MonoBehaviour
{

    public int score;
    public int qofPlayers;
    public string userName;
    public int qOfFirstShopItem, qOfSecondShopItem, qOfThirdShopItem;


    // Start is called before the first frame update
    void Start()
    {
        qofPlayers = PlayerPrefs.GetInt("qofPlayers");
        userName = PlayerPrefs.GetString("userName");
        score = PlayerPrefs.GetInt($"{userName}_score");
        qOfFirstShopItem = PlayerPrefs.GetInt($"{userName}_qOfFirstShopItem");
        qOfSecondShopItem = PlayerPrefs.GetInt($"{userName}_qOfSecondShopItem");
        qOfThirdShopItem = PlayerPrefs.GetInt($"{userName}_qOfThirdShopItem");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
