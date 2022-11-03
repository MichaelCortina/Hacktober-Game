using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public sealed class MapManager : MonoBehaviour
{
    [SerializeField] private Tilemap map;
    [SerializeField] private TileInfo groundTile;
    [SerializeField] private List<TileInfo> tileInfo;

    private Dictionary<TileBase, TileInfo> _infoFromTiles;

    public TileInfo InfoAtPosition(Vector3 worldPosition)
    {
        var cellPosition = map.WorldToCell(worldPosition);
        var tileBase = map.GetTile(cellPosition);
        return (tileBase != null) ? _infoFromTiles[tileBase] : groundTile;
    }
        
    private void Awake()
    {
        _infoFromTiles = new Dictionary<TileBase, TileInfo>();
        
        foreach (var info in tileInfo)
            foreach (var tileBase in info.Tiles)
                _infoFromTiles.Add(tileBase, info);
    }
}