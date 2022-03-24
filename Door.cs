using UnityEngine;

public class Door() {
    public bool isOpen
    bool isLocked;
    //Text lockMessage;
    public Animator doorAni;
    bool needsRedKey,needsBlueKey,needsGreenKey;

    public void Awake() {
        doorAni = GetComponent < Animator > ();
        isLocked;
    }
    public void Update {
        switch(isLocked){
            case (needsGreenKey && player.hasGreenKey)
                isLocked = false;
                break;
                case (needsRedKey && player.hasRedKey)
                isLocked = false;
                break;
                case (needsBlueKey && player.hasBlueKey)
                isLocked = false;
                break;
                case (needsBlueKey && player.!hasBlueKey)
                isLocked;
                break;
                case (needsRedKey && player.!hasRedKey)
                isLocked;
                break;
                case (needsGreenKey && player.!hasGreenKey)
                isLocked;
                break;
                case (!needsGreenKey&&!needsRedKey&&!needsBlueKey)
                isLocked=false;
                default;
            }
        }
    }
    public void OnTriggerEnter(collider other) {
        //collision with player trigger only
        if (isLocked) {
            //check if its locked
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
