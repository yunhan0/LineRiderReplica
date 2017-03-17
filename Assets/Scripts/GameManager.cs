using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public GameObject player;
	private Rigidbody2D rb;

	void Start() {
		rb = player.GetComponent<Rigidbody2D> ();
	}

	public void MovePlayer() {
		rb.bodyType = RigidbodyType2D.Dynamic;
	}

	public void StopPlayer() {
		rb.bodyType = RigidbodyType2D.Static;
	}

	public void RestartGame() {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}
}
