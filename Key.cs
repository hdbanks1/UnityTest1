using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Key : MonoBehaviour
{
    GameObject player;
    public Text pickupText;
    // Start is called before the first frame update
    void Start(){
        player = GameObject.FindWithTag("Player");
    }
   void OnTriggerEnter(Collider other){
       if(other.gameObject.tag=="Player"){
                if(Input.GetButtonDown("Use")){
            transform.parent = player.transform;
            }  
   }

    // Update is called once per frame
    void Update()
    {
        
    }
}
