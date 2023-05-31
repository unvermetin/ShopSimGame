using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject itemText;

    public int itemStock;
    public float money = 0f;
    public float dailyExpenses = 5f;
    public int dayNumber = 0;
    public bool finishDay = false;
    public int customerAtShop = 0;
    public int customerOnLine = 0;
    public float numberOfCustomer = 1;
    public float advertisementPrice = 5;

    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI stockText;
    public TextMeshProUGUI cusSpwText;
    public TextMeshProUGUI dayText;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
       
    }
    void Update()
    {
        if (itemStock == 0)
        {
            finishDay = true;

            if (customerOnLine == 0 && customerAtShop==0)
            {
                DayFinish();
            }
        }

       
        cusSpwText.text = advertisementPrice.ToString();
        stockText.text = itemStock.ToString();
        moneyText.text = money.ToString();
        stockText.text = itemStock.ToString();
        dayText.text = "Day: " + dayNumber.ToString();
    }

    public void DayFinish()
    {
        print("Day arttý");
        dayNumber++;
        SceneManager.LoadScene("DayScene");
    }

    public void ItemSold()
    {
        CustomerBuy();
    }


    void CustomerBuy()
    {
        if (itemStock > 0)
        {
            itemStock--;
            money++;
        }

    }


    public void itemDestroyer(int deleteIndex)
    {
        Destroy(GameObject.Find("ItemSpawner").GetComponent<ItemSpawner>().itemCount[deleteIndex]);
    }


}
