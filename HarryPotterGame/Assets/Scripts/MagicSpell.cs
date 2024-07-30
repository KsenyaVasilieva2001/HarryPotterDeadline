using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Spell", menuName = "ScriptableObjects/Spell")]
public class MagicSpell : ItemScriptableObject
{
    /*
    [Header("Description")]
    public string spellName;
    public string spellDescription;
    
    [Header("Stats")]
    public string spellPrice;
    [Header("Icon")]
    public Sprite spellImage;
    */
    [Header("Stats")]
    public int spellPrice;
    

    void Start()
    {
        itemType = ItemType.MagicSpell;
    }
    
}
