using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTextureSetup : MonoBehaviour {
    public Camera[] cams;
    public Material[] camMaterials;
    // Use this for initialization
    void Start() {
        for (int i = 0; i < cams.Length; i++) {
            if (cams[i].targetTexture != null)
            {
                cams[i].targetTexture.Release();
            }
            cams[i].targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
            camMaterials[i].mainTexture = cams[i].targetTexture;
        }
	}
}
