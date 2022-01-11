using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Builder : MonoBehaviour
{
	public Tilemap map;
	public Tilemap overlayMap;
	public TileBase tile;
	public bool isPlacing = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		// Change placing status
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			overlayMap.ClearAllTiles();
			this.isPlacing = false;
		}

		// Make placeholder for tile placement
		if(Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0) {
			if (this.isPlacing == true) {
				overlayMap.ClearAllTiles();

				Vector2 screenPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
				Vector2 worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);

				Vector3Int currentCell = map.WorldToCell(worldPosition);
				currentCell.z = 0;

				overlayMap.SetTile(currentCell, tile);
			} else {
				return;
			}
		}

        if (Input.GetKeyDown(KeyCode.Mouse0)) {
			//Debug.Log("Hello World");

			if (this.isPlacing == true) {
				Vector2 screenPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
				Vector2 worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);

				Vector3Int currentCell = map.WorldToCell(worldPosition);

				currentCell.z = 0;

				Debug.Log(currentCell.ToString());

				map.SetTile(currentCell, tile);
			}

		}
    }

	public void enablePlacingMode() {
		this.isPlacing = true;
	}

	public void disablePlacingMode() {
		this.isPlacing = false;
	}
}
