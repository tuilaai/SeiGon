using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    [SerializeField] protected float speed;
    [SerializeField] protected Vector3 testpos;
    [SerializeField] protected LayerMask RayLayer;
    [SerializeField] protected Camera RayCam;
    [SerializeField] float ZRot;

   Vector3 movepos()
    {
        Ray ray = RayCam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit, float.MaxValue, RayLayer))
        {
            Vector3 pos = hit.point;


            return pos;
        }

        //Vector3 newpos = Vector3.Lerp(this.transform.position, movepos(), speed);
        return this.transform.position;
    }
    void checkRot()
    {
        if (Input.GetAxis("Mouse X") > 0)
        {
            ZRot = -40;
        }
        else if (Input.GetAxis("Mouse X") < 0)
        {
            ZRot = 40;
        }
        else
        {
            ZRot = Mathf.Lerp(ZRot, 0, Time.deltaTime * 10f);
        }
        this.transform.eulerAngles = new Vector3(this.transform.eulerAngles.x, this.transform.eulerAngles.y, ZRot);
    }
    private void FixedUpdate()
    {
        checkRot();

        this.transform.position=  Vector3.MoveTowards(this.transform.position, movepos(), speed); 
    }
}
