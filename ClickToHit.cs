using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToHit : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void OnMouseDown()
    {
        Debug.Log("GG");
        Destroy(gameObject);
    }
}
