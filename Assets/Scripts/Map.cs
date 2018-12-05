using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map {

	public int width {
		get {
			return 27;
		}
	}
	public int height {
		get {
			return 23;
		}
	}

	private TerrainTile[] hexTiles;

	public TerrainTile NorthWestTile {
		get {
			return hexTiles[0];
		}
	}
	
	public TerrainTile NorthTile {
		get {
			return hexTiles[1];
		}
	}
	
	public TerrainTile NorthEastTile {
		get {
			return hexTiles[2];
		}
	}
	
	public TerrainTile WestTile {
		get {
			return hexTiles[3];
		}
	}
	
	public TerrainTile EastTile {
		get {
			return hexTiles[4];
		}
	}
	
	public TerrainTile SouthWestTile {
		get {
			return hexTiles[5];
		}
	}
	
	public TerrainTile SouthTile {
		get {
			return hexTiles[6];
		}
	}
	
	public TerrainTile SouthEastTile {
		get {
			return hexTiles[7];
		}
	}
	

}
