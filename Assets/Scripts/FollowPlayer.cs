using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {
    public Transform portalA, portalB;
    public Transform player,playerLook;
	void Update () {
        Vector3 playerOffset = player.position - portalB.position;
        transform.position = portalA.position + playerOffset;
        float angDifPorts = Quaternion.Angle(portalB.rotation, portalA.rotation);

        Quaternion portalRotDiff = Quaternion.AngleAxis(angDifPorts, Vector3.up);
        Vector3 newCamDir = portalRotDiff * playerLook.forward;
        transform.rotation = Quaternion.LookRotation(newCamDir, Vector3.up);
    }
}
