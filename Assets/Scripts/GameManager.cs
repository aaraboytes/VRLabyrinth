using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public static GameManager _instance;
    bool teleporting = false;
    private void Awake()
    {
        if (_instance == null)
            _instance = this;
        else if (_instance != this)
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }
    public bool GetTeleporting()
    {
        return teleporting;
    }
    public void EnableTeleporting()
    {
        teleporting = true;
    }
    public void DisableTeleporting()
    {
        Invoke("TeleportingToFalse", 0.5f);
    }
    void TeleportingToFalse()
    {
        teleporting = false;
    }
}
