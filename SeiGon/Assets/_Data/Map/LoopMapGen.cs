using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopMapGen : Singleton<LoopMapGen>
{
    [SerializeField] protected Tile tile;
    [SerializeField] protected List<Tile> tileList = new List<Tile>();
    public int count;
    [SerializeField] protected Vector3 pos;
    [SerializeField] protected float speed;
    void Start()
    {
        Spawn();
    }
    void Spawn()
    {
        for (int x = 0; x < count; x++)
        {
           
            Tile a = Instantiate(tile, this.transform.position, Quaternion.identity);
            a.speed = speed;
            a.tileCount = count;
            a.index = x;
            tileList.Add(a);
        }
    }
    public void UpdateCount()
    {
        foreach (Tile a in tileList)
        {
            if (a.index == count)
            {
                a.index = 0;
            }
            a.index++;
          
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
