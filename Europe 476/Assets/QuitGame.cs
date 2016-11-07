using UnityEngine;
using System.Collections;

public class QuitGame : MonoBehaviour {

	public void TaskOnClick(){
		Debug.Log ("it working!");
		Application.Quit ();
	}
}