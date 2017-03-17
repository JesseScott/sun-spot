using UnityEngine;
using System.Collections;

public class SplashScene : MonoBehaviour {

	void Start () 
	{
		StartCoroutine("Countdown");
	}

	private IEnumerator Countdown()
	{
		yield return new WaitForSeconds(5);
		Application.LoadLevel(1);
	}
	
}
