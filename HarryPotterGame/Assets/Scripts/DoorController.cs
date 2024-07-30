using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    public GameObject player;
    public float reachDistance = 5f;


  
    private void Update()
    {
        if (this.CompareTag("ExitDoor"))
        {
            if (Vector3.Distance(this.transform.position, player.transform.position) < reachDistance)
            
            {
                GameObjectExtension.Find("ExitButton").SetActive(true); 
                
            }
            else
            {
                GameObjectExtension.Find("ExitButton").SetActive(false);
            }
        }
       
    }
}


