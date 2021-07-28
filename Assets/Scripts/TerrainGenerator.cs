using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class TerrainGenerator : MonoBehaviour
{
    public GameObject InitialBlock;
    public GameObject[] TerrainBlocks;
    private int BlockIndex = 0;
    private List<GameObject> CurrenBlocks = new List<GameObject>();
    void Start()
    {
       for (int i = 0; i < 4; i++)
        {
            GenerateBlock();
        } 
    }
    void GenerateBlock()
    {
        var index = Random.Range(0, TerrainBlocks.Length);
        var prefab = TerrainBlocks[index];
        if (BlockIndex < 2)
            prefab = InitialBlock;
        var block = Instantiate(prefab);
        CurrenBlocks.Add(block);
        block.transform.position = Vector2.right * BlockIndex * 8f;
        GetComponent<BoxCollider2D>().transform.position= Vector2.right * (BlockIndex - 2)* 8f;
        BlockIndex++;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GenerateBlock();
        var block = CurrenBlocks.First();
        Destroy(block);
        CurrenBlocks.RemoveAt(0);
    }
}
