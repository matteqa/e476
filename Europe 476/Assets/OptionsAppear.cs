using UnityEngine;
using System.Collections;

public class OptionsAppear : MonoBehaviour {
	
	public void ShowOptions() {
		Debug.Log ("test");
		transform.SetAsFirstSibling();
	}
}
