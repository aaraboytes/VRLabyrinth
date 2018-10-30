using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalPass : MonoBehaviour {
    public Transform player;
    public Transform receiver;
    public bool rotatePlayer = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !GameManager._instance.GetTeleporting())
        {
            //Checks if the player is facing the portal
            Vector3 portalToPlayer = player.position - transform.position;
            float dotProduct = Vector3.Dot(transform.up, portalToPlayer);
            Debug.Log("playerposition from " + name + " " + player.position);
            if (dotProduct < 0.2f)
            {
                float rotationDiff = -Quaternion.Angle(transform.rotation, receiver.rotation);
                if(rotatePlayer)
                    rotationDiff += 180f;
                player.Rotate(Vector3.up, rotationDiff);

                Vector3 positionOffset = Quaternion.Euler(0f, rotationDiff, 0f) * portalToPlayer;
                player.position = receiver.position + positionOffset;
                GameManager._instance.EnableTeleporting();
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            GameManager._instance.DisableTeleporting();
    }
}
