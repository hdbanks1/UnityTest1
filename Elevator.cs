using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    public Transform wayPoint;
    public Vector3[] wayPoints ; 
    public GameObject Elvt;
    int speed;
    AudioClip ding;
    bool arrivedAtFloor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach(Vector3 i in wayPoints){
            Elvt.transform.Translate(i);
        }
    }
}
