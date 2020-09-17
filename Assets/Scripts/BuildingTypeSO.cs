﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "ScriptableObjects/BuildingType")]
public class BuildingTypeSO : ScriptableObject{

    [SerializeField]private string nameString;
    [SerializeField] private Transform prefab;
    
}
