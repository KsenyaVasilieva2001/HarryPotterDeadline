using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    public float health;
    public int numOfHearts;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    void Update()
    {
        if (health > numOfHearts)
        {
            health = numOfHearts;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < Mathf.RoundToInt(health))
            {
                GameObject.Find("HealthPoints").transform.GetChild(i).GetComponent<Image>().sprite = fullHeart;
                //hearts[i].sprite = fullHeart;
               // Debug.Log(fullHeart);
            //    Debug.Log(hearts[i].sprite);
            }
            else
            {
                GameObject.Find("HealthPoints").transform.GetChild(i).GetComponent<Image>().sprite = emptyHeart;
               // hearts[i].sprite = emptyHeart;
            }

            if (i < numOfHearts)
            {
                GameObject.Find("HealthPoints").transform.GetChild(i).GetComponent<Image>().enabled = true;
           //   hearts[i].enabled= true;
            }
            else
            {
                GameObject.Find("HealthPoints").transform.GetChild(i).GetComponent<Image>().enabled = false;
             //  hearts[i].enabled= false;
            }
        }

        if (health < 1)
        {
            Inventory inventory = GameObject.Find("Canvas").GetComponent<Inventory>();
            for (int i = 0; i < inventory.slots.Count; i++)
            {
                inventory.RemoveItemFromSlot(i);
            }
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Cat")
        {
            health -= 1;
            
        }
    }
}