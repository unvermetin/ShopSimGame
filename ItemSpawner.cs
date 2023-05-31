using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public static ItemSpawner instance;
    int itemStockValue;
    Vector3 firstPosition;
    public float gap;
    public GameObject objectToCreate;
    public float high;
    public GameObject[] itemCount;

    void Start()
    {
        firstPosition = gameObject.transform.position;
        itemStockValue = GameManager.instance.itemStock;
        itemCount = new GameObject[itemStockValue];
        Vector3 position = firstPosition;
        for (int i = 0; i < itemStockValue; i++)
        {
            itemCount[i] = Instantiate(objectToCreate, position, Quaternion.identity) as GameObject;
            position.z += gap;


            //sýra dolduysa üst srýaya geçer
            if (( i+1) % 10== 0)
            {
                position.y += high;
                position.z = firstPosition.z;
            }
           
        }
    }


    void Update()
    {
        
    }

    //her þeyi siliyor
    void ItemRemover()
    {

        for (int z = itemStockValue; z > 0; z--) {
            int indexNumberToRemove = z -1;
            Destroy(itemCount[indexNumberToRemove]);
            // remove the empty slot in the array 
      //      int i = 0;
      //      GameObject[] ret = new GameObject[itemCount.Length -1];
      //      while (i < ret.Length)
      //      {
      //          int i2 = i;
      //          if (i >= indexNumberToRemove) { i2--; }
      //          ret[i] = itemCount[i2];
      //          i++;
      //      }
        }
        
    }

}
