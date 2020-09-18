using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="ScriptableObjects/BuildingTypeList")]
public class BuildingTypeListSO : ScriptableObject
{
    [SerializeField] private List<BuildingTypeSO> buildingTypeList;


    //Return list containing every scriptable object of buildings
    public List<BuildingTypeSO> getBuildingTypeList()
    {
        return buildingTypeList;
    }
}
