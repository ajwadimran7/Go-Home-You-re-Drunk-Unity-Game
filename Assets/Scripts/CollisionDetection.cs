using UnityEngine;

public class CollisionDetection : MonoBehaviour {

	public string TagToCheck;

	void OnTriggerEnter (Collider obstacle) {
		if (obstacle.CompareTag (TagToCheck)) {
			Debug.Log ("Game Over!");
		}
	} 
}
