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

	private HexTile[] hexTiles;

	public HexTile NorthWestTile {
		get {
			return hexTiles[0];
		}
	}
	
	public HexTile NorthTile {
		get {
			return hexTiles[1];
		}
	}
	
	public HexTile NorthEastTile {
		get {
			return hexTiles[2];
		}
	}
	
	public HexTile WestTile {
		get {
			return hexTiles[3];
		}
	}
	
	public HexTile EastTile {
		get {
			return hexTiles[4];
		}
	}
	
	public HexTile SouthWestTile {
		get {
			return hexTiles[5];
		}
	}
	
	public HexTile SouthTile {
		get {
			return hexTiles[6];
		}
	}
	
	public HexTile SouthEastTile {
		get {
			return hexTiles[7];
		}
	}
	

}
