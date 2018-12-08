using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class MapGenerator {

	private string terrainTileFilePath = "/Data/terrainTiles.json";
	private HexGrid hexGrid;
	private int numPlayers;

	public MapGenerator(HexGrid hexGrid, int numPlayers) {
		this.hexGrid = hexGrid;
		this.numPlayers = numPlayers;
	}

	public void Generate() {
		Debug.Log("In Generate");
		List<TerrainTile> terrainTiles = readTerrainTiles();
		DrawTileAtPoint(terrainTiles[0], new Vector3(11,-17,6));
	}

	private void DrawTileAtPoint(TerrainTile tile, Vector3 position) {
		List<Vector3> spiralWalkOfTile = new List<Vector3>();
		spiralWalkOfTile.Add(position);
		int radius = 4;
		for(int i=1; i<=radius; i++) {
			spiralWalkOfTile.AddRange(FindRing(position, i));
		}

		if(spiralWalkOfTile.Count != tile.front.Length) {
			throw new ApplicationException(String.Format("Length of spiral walk {0} and length of hex terrain string {1} are different", spiralWalkOfTile.Count, tile.front.Length));
		}
		for(int i=0; i< spiralWalkOfTile.Count; i++) {
			HexCell cell = hexGrid.getCellForPosition(spiralWalkOfTile[i]);
			HexCell.TerrainType terrainType = HexCell.GetTerrainForChar(tile.front[i]);
			Debug.Log(String.Format("Drawing terrain '{0}' at position {1}", tile.front[i], spiralWalkOfTile[i]));
			cell.SetTerrain(terrainType);
		}
	}

	private List<Vector3> FindRing(Vector3 position, int radius) {
		List<Vector3> ring = new List<Vector3>();
		Vector3 newPosition = position + HexMetrics.HexDirection(4) * radius;
		for(int i=0; i<6; i++) {
			for(int j=0; j<radius; j++) {
				ring.Add(newPosition);
				newPosition = HexMetrics.GetNeighbor(newPosition, i);
			}
		}
		return ring;
	}

	private List<TerrainTile> readTerrainTiles() {
		string fullPath = Application.dataPath + terrainTileFilePath;
		if (!File.Exists(fullPath)) {
			throw new System.IO.FileNotFoundException(String.Format("File {0} does not exist", fullPath));
		}
		string rawJson = File.ReadAllText(fullPath);
		Debug.Log(rawJson);
		TerrainTile[] tiles = JsonHelper.FromJson<TerrainTile>(rawJson);
		return new List<TerrainTile>(tiles);
	}
}
