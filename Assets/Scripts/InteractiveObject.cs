using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour {
    Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void StartAction()
    {
        Debug.Log("Starting action");
        anim.SetTrigger("Activate");
    }
}
