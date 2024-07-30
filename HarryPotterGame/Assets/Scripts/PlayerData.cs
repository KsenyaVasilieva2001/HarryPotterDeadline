using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] // дает возможность сохранить этот класс в файл
public class PlayerData
{
    public float health;

    public string[] itemNames;
    public int[] itemAmounts;

    public PlayerData (HealthController _healthController, Inventory _inventory)
    {
        health = _healthController.health;

        itemNames = new string[_inventory.slots.Count];
        itemAmounts = new int[_inventory.slots.Count];
    
        for (int i = 0; i < _inventory.slots.Count; i++)
        {
            if(_inventory.slots[i].item != null)
                itemNames[i] = _inventory.slots[i].item.name;
        }
    
        for (int i = 0; i < _inventory.slots.Count; i++)
        {
            if(_inventory.slots[i].item != null)
                itemAmounts[i] = _inventory.slots[i].amount;
        }
    }
}