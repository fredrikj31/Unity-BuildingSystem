using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class SelectBuilding : MonoBehaviour
{
	public GameObject buildingManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void selectBuildingTile(TileBase inputTile) {
		Builder myBuilder = buildingManager.GetComponent<Builder>();

		myBuilder.enablePlacingMode();
		myBuilder.tile = inputTile;
	}
}
