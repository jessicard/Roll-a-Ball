using UnityEngine;
using System.Collections;

public class ButtonController : MonoBehaviour {

	public void StartGame(){
		Application.LoadLevel("MiniGame");
	}

	public void ExitGame(){
		Application.Quit ();
	}

}
