using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerSpawnerScript : MonoBehaviour
{
    public GameObject customer;
    public float CustomerSpawnSecond;
    void Start()
    {
        StartSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.finishDay || GameManager.instance.itemStock - GameManager.instance.customerOnLine == 0)
        {
            
            StopSpawn();
        }
    }


    IEnumerator CustomerSpawner()
    {

        yield return new WaitForSeconds(1f);
        while (true)
        {
            CustomerSpawn();
            yield return new WaitForSeconds(CustomerSpawnSecond);

        }

    }

    void CustomerSpawn()
    {
        if (GameManager.instance.numberOfCustomer >= 1)
        {
            Instantiate(customer, gameObject.transform.position, Quaternion.identity);
            GameManager.instance.customerAtShop++;
            GameManager.instance.customerOnLine++;
        }
        else
        {
            print("No more customer.");
        }
    }

    void StartSpawn()
    {
        StartCoroutine("CustomerSpawner");
    }

    void StopSpawn()
    {
        
        StopCoroutine("CustomerSpawner");
    }


}
