using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour {
    public Animator doorAnim;
    public void OpenDoor()
    {
        doorAnim.SetTrigger("Open");
    }
}
