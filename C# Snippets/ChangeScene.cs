using UnityEngine;
using System.Collections;
using Vuforia;

public class ChangeScene : MonoBehaviour {
	
	public void ChangeToScene (string sceneToChangeTo){
		Application.LoadLevel(sceneToChangeTo);
	}
}
