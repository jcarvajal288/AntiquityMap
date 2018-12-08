using UnityEngine;

public class HexCell : MonoBehaviour {

    public enum TerrainType {
        Forest,
        Plains,
        Mountain,
        Water
    }

    private Color green = Color.green;
    private Color yellow = Color.yellow;
    private Color red = Color.red;
    private Color blue = Color.blue;

    public HexCoordinates coordinates;
    public Color color;

    public void SetTerrain(TerrainType terrain) {
        switch(terrain) {
            case TerrainType.Forest:
                color = green;
                break;
            case TerrainType.Plains:
                color = yellow;
                break;
            case TerrainType.Mountain:
                color = red;
                break;
            case TerrainType.Water:
                color = blue;
                break;
        }
    }

    public static TerrainType GetTerrainForChar(char ch) {
        switch(ch) {
            case 'f':
            case 'F':
                return TerrainType.Forest;
            case 'p':
            case 'P':
                return TerrainType.Plains;
            case 'm':
            case 'M':
                return TerrainType.Mountain;
            case 'w':
            case 'W':
                return TerrainType.Water;
            default:
                return TerrainType.Plains;

        }
    }
}
