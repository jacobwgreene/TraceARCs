using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour 
{


	public void ChangeToSceneTower (string sceneToChangeTo) 
	{
		Application.LoadLevel ("Century Tower");
	}
	public void ChangeToSceneTurlington (string sceneToChangeTo) 
	{
		Application.LoadLevel ("TurlingtonSign");
	}
	public void ChangeToSceneUI (string sceneToChangeTo) 
	{
		Application.LoadLevel ("UIMenu");
	}
}
