using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour {

	public void StartGame(){
		Application.LoadLevel("MiniGame");
	}

	public void ExitGame(){
		Application.Quit ();
	}

}
