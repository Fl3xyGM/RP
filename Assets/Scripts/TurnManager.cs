using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour {
    
    public int TurnCounterMax = 0;
    public int TurnCounter = 0;

    void Start() {
        TurnCounterMax++;
    }

    void Update() {
    }

    public void EndTurn() {
        if(TurnCounter == TurnCounterMax-1) {
            TurnCounter = 0;
        } else {
            TurnCounter++;
        }
        Debug.Log(TurnCounter);
    }




}
