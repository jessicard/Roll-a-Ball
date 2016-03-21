using UnityEngine;
using System.Collections;

public class KeyboardInputListener : MonoBehaviour {

	void OnGUI () {
		if (Event.current.type == EventType.KeyDown) {
			if (Input.GetKey(KeyCode.Escape))
			{
				Application.LoadLevel("StartMenu");
			}
		}
	}

}
