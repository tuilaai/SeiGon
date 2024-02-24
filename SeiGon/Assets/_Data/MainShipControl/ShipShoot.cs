using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipShoot : MonoBehaviour
{
    [SerializeField] protected Transform ShootPos;
    [SerializeField] protected GameObject Bullet;
    [SerializeField] protected float delay;
    private float _delay;

  void shot()
    {
        if(Input.GetMouseButtonDown(0)&&Time.time-_delay>delay)
        {
            GameObject a = Instantiate(Bullet, ShootPos.position, Quaternion.identity);

            a.transform.localScale = Vector3.one * 5;
            Destroy(a, 12);
            _delay = Time.time;
        }
    }
    // Update is called once per frame
    void Update()
    {
        shot();
    }
}
