using UnityEngine;
using System.Collections;

	public class Spin : MonoBehaviour
	{
		public float speed = 10f;

	void Update () 
		{
			transform.Rotate(0, speed * Time.deltaTime, 0);
		}

	public void AdjustSpeed(float newSpeed){
		speed = newSpeed;
	}
}
