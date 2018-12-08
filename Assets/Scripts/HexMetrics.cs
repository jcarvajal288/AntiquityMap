using UnityEngine;

public class HexMetrics : MonoBehaviour {

    public const float outerRadius = 10f;
    public const float innerRadius = outerRadius * 0.866025404f;

    private static Vector3[] directions = { 
        new Vector3(1, -1, 0),
        new Vector3(1, 0, -1),
        new Vector3(0, 1, -1),
        new Vector3(-1, 1, 0),
        new Vector3(-1, 0, 1),
        new Vector3(0, -1, 1)
    };

    public static Vector3 HexDirection(int d) {
        return directions[d];
    }

    public static Vector3 GetNeighbor(Vector3 position, int d) {
        return position + directions[d];
    }

    public static Vector3[] corners = {
        new Vector3(0f, 0f, outerRadius),
        new Vector3(innerRadius, 0f, 0.5f * outerRadius),
        new Vector3(innerRadius, 0f, -0.5f * outerRadius),
        new Vector3(0f, 0f, -outerRadius),
        new Vector3(-innerRadius, 0f, -0.5f * outerRadius),
        new Vector3(-innerRadius, 0f, 0.5f * outerRadius),
        new Vector3(0f, 0f, outerRadius)
    };

}
