using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookController : MonoBehaviour
{
    
    public GameObject player;
    public float reachDistance = 3f;
    private int count = 0;


    public void Start()
    {
        count = 0;
    }
    private void Update()
    {
        if (this.CompareTag("Kotel"))
        {
            
            if (Vector3.Distance(this.transform.position, player.transform.position) < reachDistance)
            
            {
                GameObjectExtension.Find("CookButton").SetActive(true); 
                
            }
            else
            {
                GameObjectExtension.Find("CookButton").SetActive(false);
            }
        }
       
    }

    public void Cook()
    {
        Inventory inventory = GameObject.Find("Canvas").GetComponent<Inventory>();
        for (int i = 0; i < inventory.slots.Count; i++)
        {
            if ((inventory.slots[i].item.itemType == ItemType.Default))
            
            {
                count += inventory.slots[i].amount;
            }
            count += inventory.slots[i].amount;
        }

        Debug.Log(count);
       if (count >= 14)
       {
           AudioListener.pause = true;
           GameObject.Find("Fade").GetComponent<TransitionHandler>().LoadNextScene();
           
        }

        count = 0;
    }
}
