using UnityEngine;

public class Door() {
    public bool isOpen
    bool isLocked;
    Text lockMessage;
    public Animator doorAni;

    public void Awake() {
        doorAni = GetComponent < Animator > ();
        isLocked;
    }
    public void Update {}
    public void OnTriggerEnter(collider other) {
        //collision with player trigger only
        if (isLocked) {
            //check if its locked
            Text lockMessage = "Door is locked";
            Debug.Log("its locked here too, big dawg");
        }
        if (isLocked = false && isOpen = false;) {
            if (Input.GetButtonDown("Use") {
                doorAni.SetTrigger("Open");
                isOpen;
            }//if its unlocked and closed,open it up
                if (isOpen) {
                    if (Input.GetButtonDown("Use") {
                        doorAni.SetTrigger("Close");
                        isOpen = false;
                    }//if its open, close it. effective against AI
                    }
                }
