using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AboardPlayer : MonoBehaviour {
    public GameObject Announcer;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !TrainLevelManager._instance.GetPlayerIsAboard()){
            TrainLevelManager._instance.AboardThePlayer();
            Announcer.GetComponent<AudioSource>().Play();
        }
    }
}
