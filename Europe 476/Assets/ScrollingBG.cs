using UnityEngine;
using System.Collections;

public class ScrollingBG : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x > -1710) {
			transform.position += new Vector3 (-1f, 0f, 0f);
		} 
		else {
			transform.position += new Vector3 (3420, 0f, 0f);
		}
	}
}
