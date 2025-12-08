
using UnityEngine;

public class GridSystem
{
    public int Width { get; private set; }
    public int Height {get; private set;}
    public float CellSize {get; private set;}

    private int[,] gridArray;

    public GridSystem(int width, int height, float cellSize)
    {
        this.Width = width;
        this.Height = height;
        this.CellSize = cellSize;

        gridArray = new int[width, height];
    }

    /// <summary>
    /// Convert grid coordinates to world position (bottom-left of cell).
    /// </summary>
    public Vector2 GetWorldPosition(int x, int y)
    {
        return new Vector2(x,y) * CellSize;    
    }

    /// <summary>
    /// Convert world position to grid coordinates.
    /// </summary>
    public void GetXY(Vector2 worldPosition, out int x, out int y)
    {
        x = Mathf.FloorToInt(worldPosition.x / CellSize);
        y = Mathf.FloorToInt(worldPosition.y / CellSize);
    }

    /// <summary>
    /// Check if a grid position is inside the grid.
    /// </summary>
    public bool IsInBounds(int x, int y)
    {
        return x >= 0 && y >= 0 && x < Width && y < Height;
    }

    /// <summary>
    /// Example: store an int value in the grid.
    /// </summary>
    public void SetValue(int x, int y, int value)
    {
        if (!IsInBounds(x, y)) return;
        gridArray[x, y] = value;
    }

    public int GetValue(int x, int y)
    {
        if (!IsInBounds(x, y)) return -1;
        return gridArray[x, y];
    }
}
