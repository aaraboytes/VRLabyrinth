using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainLevelManager : MonoBehaviour {
    public static TrainLevelManager _instance;
    public GameObject moveParticles;
    public Transform particlePosition;
    bool playerIsAboardTheTrain = false;
    bool particlesSpawned = false;
    private void Awake()
    {
        _instance = this;
    }
    public bool GetPlayerIsAboard()
    {
        return playerIsAboardTheTrain;
    }
    public void AboardThePlayer()
    {
        Invoke("Aboard", 5.0f);
    }
    void Aboard()
    {
        playerIsAboardTheTrain = true;
    }
    public void NoticeSpawnParticles()
    {
        if (!particlesSpawned)
        {
            SpawnParticles();
            particlesSpawned = true;
        }
    }
    void SpawnParticles()
    {
        Instantiate(moveParticles, particlePosition.position, particlePosition.rotation);
    }
}
