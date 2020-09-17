using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour{

    //Cached references
    [SerializeField] private Camera mainCamera;

    [SerializeField] private Transform pfWoodHarvester;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(pfWoodHarvester, GetMouseWorldPosition(), Quaternion.identity);
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
