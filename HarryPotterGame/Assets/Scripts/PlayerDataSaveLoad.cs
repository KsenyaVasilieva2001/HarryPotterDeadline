using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataSaveLoad : MonoBehaviour
{
    [SerializeField] public HealthController _health;
    [SerializeField] public Inventory _inventory;
    

    public void SavePlayer()
    {
        Debug.Log(_inventory);
        BinarySavingSystem.SavePlayer(_health, _inventory);
    }

    public void LoadPlayer()
    {
        PlayerData data = BinarySavingSystem.LoadPlayer();
        Debug.Log(data);

        _health.health = data.health;

        for (int i = 0; i < _inventory.slots.Count; i++)
        {
            if (data.itemNames[i] != null)
            {
                Debug.Log(data.itemNames[i]);
              _inventory.RemoveItemFromSlot(i);
                ItemScriptableObject item = Resources.Load<ItemScriptableObject>($"ScriptableObjects/{data.itemNames[i]}");
                Debug.Log(item);
                int itemAmount = data.itemAmounts[i];
              _inventory.AddItemToSlot(item,itemAmount,i);
            }
            else
            {
                _inventory.RemoveItemFromSlot(i);
            }
        }
        
        
    }
    
}