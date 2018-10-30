using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abyss : MonoBehaviour {
    public Transform spawnPoint;
    public GameObject[] reseteableObjects;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")){
            other.transform.position = spawnPoint.position;
            foreach (GameObject obj in reseteableObjects)
                obj.SetActive(false);
        }
    }
}
