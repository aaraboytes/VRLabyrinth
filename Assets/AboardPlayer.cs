using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AboardPlayer : MonoBehaviour {
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")){
            TrainLevelManager._instance.AboardThePlayer();
        }
    }
}
