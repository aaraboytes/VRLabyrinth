using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisactivateObstacle : MonoBehaviour {
    public Animator obstacleAnim;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            obstacleAnim.SetTrigger("Exit");
        }
    }
}
