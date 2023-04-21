using UnityEngine;

[ExecuteInEditMode]
public class FaceCamera : MonoBehaviour {
	public bool DebugReport = false;
	Vector3 cameraDir;
	// Update is called once per frame
	void OnRenderObject() {
		Vector3 CamPos = transform.position + Camera.main.transform.rotation * -Vector3.back;
		transform.LookAt(CamPos, Vector3.up);
	}
}
