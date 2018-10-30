using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicPlatform : MonoBehaviour {
    GameObject platform;
    private void Start()
    {
        platform = transform.GetChild(0).gameObject;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            platform.GetComponent<Animator>().SetTrigger("Activate");
            GetComponent<AudioSource>().Play();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            platform.GetComponent<Animator>().SetTrigger("Disactivate");
        }
    }
}
