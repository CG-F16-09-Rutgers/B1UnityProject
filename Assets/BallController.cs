using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour {

	public float speed;
	private Rigidbody rb;
	public Camera mainCamera;

	void Start(){
		rb = GetComponent<Rigidbody> ();
	}

	void Update(){
		if (Input.GetKey (KeyCode.R)) {
			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
		}
	}

	void FixedUpdate(){
		Vector3 moveHorizontal = Input.GetAxis ("Horizontal") * mainCamera.transform.right;
		Vector3 moveVertical = Input.GetAxis ("Vertical") * mainCamera.transform.forward;

		Vector3 movement = moveHorizontal + moveVertical;

		rb.AddForce (movement * speed);
	}
}
