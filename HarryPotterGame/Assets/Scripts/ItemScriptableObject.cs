﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum ItemType {Default, MagicSpell, Apple}


public class ItemScriptableObject : ScriptableObject
{

    public ItemType itemType;
    public string name;
    public int maximumAmount;
    [Multiline(5)]
    public String description;

    public Sprite icon;
    public GameObject prefab;
    public Vector3 rotateAngle;
}