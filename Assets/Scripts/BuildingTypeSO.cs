using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "ScriptableObjects/BuildingType")]
public class BuildingTypeSO : ScriptableObject{

    [SerializeField]private string nameString;
    [SerializeField] private Transform prefab ;


    //Return a tranform reference to the prefab given
    public Transform getPrefab()
    {
        return prefab;
    }

    
}
