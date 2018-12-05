using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class MapGenerator {

	private string terrainTileFilePath = "/Data/terrainTiles.json";

	public void Generate(int numPlayers) {
		List<TerrainTile> terrainTiles = readTerrainTiles();
		foreach(TerrainTile tile in terrainTiles) {
			Debug.Log(tile.name);
			Debug.Log(tile.front);
			Debug.Log(tile.back);
			Debug.Log(tile.count);
		}

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
