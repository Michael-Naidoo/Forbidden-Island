using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour

{
    [SerializeField] private GameObject[] tiles;
    [SerializeField] private GameObject[] boardPositions;
    [SerializeField] private GameObject[] treasureCards;
    [SerializeField] private GameObject[] floodCards;
    [SerializeField] private GameObject[] treasures;
    [SerializeField] private GameObject[] players;
    
    public void Start()
    {
        TileManager();
        TileSorter();
        FloodManager();
        TreasureCardManager();
    }

    private void TileManager()
    {
        int maxTiles = tiles.Length;
        int halfTiles = tiles.Length / 2;
        for (int i = 0; i < halfTiles; i++)
        {
            int position1 = Random.Range(0, maxTiles);
            int position2 = Random.Range(0, maxTiles);
            GameObject tile1 = tiles[position1];
            GameObject tile2 = tiles[position2];
            tiles[position1] = tile2;
            tiles[position2] = tile1;
        }
    }

    private void TileSorter()
    {
        int length = tiles.Length;

        for (int i = 0; i < length; i++)
        {
            tiles[i].transform.position = boardPositions[i].transform.position;
        }
    }

    private void FloodManager()
    {
        int maxTiles = floodCards.Length;
        int halfTiles = floodCards.Length / 2;
        for (int i = 0; i < halfTiles; i++)
        {
            int position1 = Random.Range(0, maxTiles);
            int position2 = Random.Range(0, maxTiles);
            GameObject tile1 = floodCards[position1];
            GameObject tile2 = floodCards[position2];
            floodCards[position1] = tile2;
            floodCards[position2] = tile1;
        }
    }

    private void TreasureCardManager()
    {
        int maxTiles = treasureCards.Length;
        int halfTiles = treasureCards.Length / 2;
        for (int i = 0; i < halfTiles; i++)
        {
            int position1 = Random.Range(0, maxTiles);
            int position2 = Random.Range(0, maxTiles);
            GameObject tile1 = treasureCards[position1];
            GameObject tile2 = treasureCards[position2];
            treasureCards[position1] = tile2;
            treasureCards[position2] = tile1;
        }
    }
}
