using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlane : MonoBehaviour {
    public float speed, acceleration, minPosition;
    float currentSpeed;
    private void Update()
    {
        if (TrainLevelManager._instance.GetPlayerIsAboard())
        {
            if (currentSpeed < speed)
                currentSpeed += acceleration;
            else
            {
                currentSpeed = speed;
            }
            transform.Translate(transform.forward * -currentSpeed * Time.deltaTime);
            if (transform.position.z <= minPosition)
                gameObject.SetActive(false);
        }
    }
}
