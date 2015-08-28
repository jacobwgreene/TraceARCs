using UnityEngine;
using System.Collections;
using Vuforia;

public class Hyperlink : MonoBehaviour {

	public void website (){
		Application.OpenURL ("http://google.com");
	}
}
