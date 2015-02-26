using UnityEngine;
using System.Collections;

public class Hyperlink : MonoBehaviour {
	void OnMouseUpAsButton() {
		Application.OpenURL("http://www.english.ufl.edu/");
	}
}
