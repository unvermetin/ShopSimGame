using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DayButtonController : MonoBehaviour
{

    public TextMeshProUGUI dayTextMenu;
    public TextMeshProUGUI moneyTextMenu;
    public TextMeshProUGUI dailyExpensesTextMenu;
    int dayNumberMenu=0;
    float moneyMenu=0f;
    float dailyExpensesMenu=0f;


    void Start()
    {
        dayNumberMenu = GameManager.instance.dayNumber;
        moneyMenu = GameManager.instance.money;
        dailyExpensesMenu = GameManager.instance.dailyExpenses;

    }

    // Update is called once per frame
    void Update()
    {
        dayTextMenu.text = "Day: " + dayNumberMenu.ToString();
        moneyTextMenu.text = "Money: " + moneyMenu.ToString();
        dailyExpensesTextMenu.text = "Daily Expenses: " + dailyExpensesMenu.ToString();
    }

    public void MakeAdvertisement()
    {
        if (moneyMenu >= GameManager.instance.advertisementPrice)
        {
            GameManager.instance.numberOfCustomer *=1.2f;
            GameManager.instance.money -= GameManager.instance.advertisementPrice;
            GameManager.instance.advertisementPrice = GameManager.instance.advertisementPrice * 1.2f;
            
        }
    }
    public void RenewStock()
    {
        if (moneyMenu >= GameManager.instance.advertisementPrice)
        {
            GameManager.instance.numberOfCustomer *= 1.2f;
            GameManager.instance.money -= GameManager.instance.advertisementPrice;
            GameManager.instance.advertisementPrice = GameManager.instance.advertisementPrice * 1.2f;

        }
    }
    public void ImproveShop()
    {
        if (moneyMenu >= GameManager.instance.advertisementPrice)
        {
            GameManager.instance.numberOfCustomer *= 1.2f;
            GameManager.instance.money -= GameManager.instance.advertisementPrice;
            GameManager.instance.advertisementPrice = GameManager.instance.advertisementPrice * 1.2f;

        }
    }
}
