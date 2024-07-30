using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpellController : MonoBehaviour
{
   // private Camera mainCamera;
    private GameObject point;
    public float richDistance = 10f;
    public GameObject currentSpell;
    public ChoosingSlotInventory slot;
    
    void Start()
    {
        point = GameObject.FindGameObjectWithTag("point");
        slot = FindObjectOfType<ChoosingSlotInventory>();
        currentSpell = slot.currentWeapon;
    }

    
    void Update()
    {
        
        Ray ray = Camera.main.ScreenPointToRay(point.transform.position);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, richDistance))
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                Debug.Log("Нажалось");
                Debug.Log(currentSpell);
                Debug.Log(currentSpell.tag);
                if (currentSpell != null && currentSpell.CompareTag("Totalus"))
                {
                    if (hit.collider.gameObject.GetComponent<Cat>() != null)
                    {
                        Destroy(hit.collider.gameObject);
                    }
                }
                else
                {
                    if (currentSpell != null && currentSpell.CompareTag("ALohomora"))
                    {
                        Debug.Log("Выпустилось");
                        Debug.Log(hit.collider.gameObject);
                        if (hit.collider.gameObject.GetComponent<OpenDoorController>() != null)
                        {
                            
                            OpenDoorController door = hit.collider.gameObject.GetComponent<OpenDoorController>();
                            door.Open();
                        }
                    }
                }
               
            } 

        }
    }
}
