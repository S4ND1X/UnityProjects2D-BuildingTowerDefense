using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{

    private Dictionary<ResourceTypeSO, int> resourceAmountDictionary;



    private void Awake(){
        //Initialize the dictionary with current types of resources and set to 0
        resourceAmountDictionary = new Dictionary<ResourceTypeSO, int>();
        ResourceTypeListSO resourceTypeList = Resources.Load<ResourceTypeListSO>(typeof(ResourceTypeListSO).Name);

        foreach(ResourceTypeSO resourceType in resourceTypeList.getResourcesTypeList()){
            resourceAmountDictionary[resourceType] = 0;
        }

    }

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    private void Update(){
        //Testing if it works add resources
        if (Input.GetKeyDown(KeyCode.Space)){
            ResourceTypeListSO resourceTypeList = Resources.Load<ResourceTypeListSO>(typeof(ResourceTypeListSO).Name);
            addResource(resourceTypeList.getResourcesTypeList()[0], 1);
            TestLogDic();
        }
    }

    private void TestLogDic(){
        foreach(ResourceTypeSO resourceType in resourceAmountDictionary.Keys){
            Debug.Log(resourceType.getNameString() + " : " + resourceAmountDictionary[resourceType]);
        }
    }

    public void addResource(ResourceTypeSO resourceType, int amount){
        resourceAmountDictionary[resourceType] += amount;
    }
}
