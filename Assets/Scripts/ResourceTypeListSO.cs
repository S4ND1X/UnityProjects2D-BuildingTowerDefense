using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="ScriptableObjects/ResourcesTypeList")]
public class ResourceTypeListSO : ScriptableObject{
    [SerializeField] private List<ResourceTypeSO> resourcesTypeList;

    public List<ResourceTypeSO> getResourcesTypeList(){
        return resourcesTypeList;
    }
}
