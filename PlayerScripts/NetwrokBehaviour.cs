using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class NetwrokBehaviour : NetworkBehaviour {
    [SerializeField]
    Behaviour[] ComToDisable;
    void Start () {
        if (!isLocalPlayer)
        {
            for(int i = 0; i < ComToDisable.Length; i++)
            {
                ComToDisable[i].enabled = false;
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
