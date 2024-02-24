using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public float speed;
    public int tileCount;
    public int index;
    public int test;
    [SerializeField] protected List<GameObject> BuildingList = new List<GameObject>();
  
    void Start()
    {
        this.transform.position += Vector3.forward * -400+ (Vector3.forward * this.transform.localScale.z * index);
    }
    void GenerateBuilding()
    {

    }
    void Update()
    {
        test = LoopMapGen.Instance.count - 1;
        transform.position += Vector3.forward*Time.deltaTime*speed;
        if (this.transform.position.z>this.transform.localScale.z* 2&& index>=LoopMapGen.Instance.count-1)
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, -this.transform.localScale.z);
            LoopMapGen.Instance.UpdateCount();
        }
    }
}
