using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour{

    //Cached references
    [SerializeField] private Camera mainCamera;
    private BuildingTypeListSO buildingTypeList;
    private BuildingTypeSO buildingType;
    private void Awake(){
        buildingTypeList = Resources.Load<BuildingTypeListSO>(typeof(BuildingTypeListSO).Name);
        buildingType = buildingTypeList.getBuildingTypeList()[0];
    }

    private void Update(){
        if (Input.GetMouseButtonDown(0)){
            Instantiate(buildingType.getPrefab(), GetMouseWorldPosition(), Quaternion.identity);
        }

        if (Input.GetKeyDown(KeyCode.Alpha1)){
            buildingType = buildingTypeList.getBuildingTypeList()[0];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2)){
            buildingType = buildingTypeList.getBuildingTypeList()[1];
        }

    }

    private Vector3  GetMouseWorldPosition(){
        /*Screen to world Point converts a screen point that would be given as pixels depending on your computer
        * into coordinates corresponding to the "world" of the game
        */
        Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0f;
        return mouseWorldPosition;
    }
}
