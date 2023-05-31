using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CustomerMove : MonoBehaviour
{
    GameObject firstDestination;
    GameObject secondDestination;
    NavMeshAgent customer;

    public bool isItemSold=false;



    void Awake()
    {
        firstDestination = GameObject.Find("FirstDestination");
        secondDestination = GameObject.Find("SecondDestination");
    }

    void Start()
    {
        customer = GetComponent<NavMeshAgent>();
    }



    void Update()
    {
        if (isItemSold == false)
        {
            
            customer.SetDestination(firstDestination.transform.position);
        }
        if (isItemSold == true)
        {
            customer.SetDestination(secondDestination.transform.position);
            
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == ("Shop"))
        {
            GameManager.instance.customerOnLine--;
            GameManager.instance.ItemSold();
            GameManager.instance.itemDestroyer(GameManager.instance.itemStock);
            isItemSold = true;

        }
        if (other.gameObject.tag == ("OutShop"))
        {
            GameManager.instance.customerAtShop--;
            Destroy(gameObject);

            isItemSold = false;
        }
    }
}
