using UnityEngine;

public class Camera : MonoBehaviour {

	public Transform target;

	public float speed;

	public float xOffset;
	public float yOffset;
	public float zOffset;

	void Update() {
		if(target) {
			Vector3 position = new Vector3 (target.position.x + xOffset, target.position.y + yOffset, target.position.z + zOffset);
			transform.position = Vector3.Lerp (transform.position, position, speed * Time.deltaTime);
		}
	}
}
