using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TunnelMovement : MonoBehaviour {
    public float maxPosition;
    public float minPosition;
    public float speed;
    public float acceleration;

    public GameObject moveParticles;
    float currentSpeed = 0f;
    bool running = false;
	
	void Update () {
        if (TrainLevelManager._instance.GetPlayerIsAboard()){
            if (currentSpeed < speed)
                currentSpeed += acceleration;
            else
            {
                currentSpeed = speed;
                if (!running)
                {
                    TrainLevelManager._instance.NoticeSpawnParticles();
                    running = true;
                }
            }
            transform.Translate(transform.forward * -currentSpeed * Time.deltaTime);
            if (transform.position.z <= minPosition)
                transform.position = new Vector3(transform.position.x, transform.position.y, maxPosition);
        }
	}
}
