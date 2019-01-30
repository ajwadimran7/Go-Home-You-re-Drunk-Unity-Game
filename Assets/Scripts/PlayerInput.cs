using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public class PlayerInput : MonoBehaviour {

	Movement _movement;

	void Start() {
		_movement = GetComponent<Movement> ();
	}

	void Update() {
		if (_movement) {

			float horizontal = Input.GetAxis ("Horizontal");

			_movement.XAxisSpeed = horizontal;

			if (horizontal > 0f) {
				_movement.setXSpeedSign (1f);
			} else if (horizontal < 0f) {
				_movement.setXSpeedSign (-1f);
			}
		}
	}
}
