using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Chick : MonoBehaviour{

	public Rigidbody2D Rb;
	public Rigidbody2D hook;

	public float releaseTime = .15f;
	public float maxDragDistance = 2f;

	public GameObject nextBall;

	private bool isPressed = false;

	void Update()
	{
		if (isPressed)
		{
			Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

			if (Vector3.Distance(mousePos, hook.position) > maxDragDistance)
				Rb.position = hook.position + (mousePos - hook.position).normalized * maxDragDistance;
			else
				Rb.position = mousePos;
		}
	}

	void OnMouseDown()
	{
		isPressed = true;
		Rb.isKinematic = true;
	}

	void OnMouseUp()
	{
		isPressed = false;
		Rb.isKinematic = false;

		StartCoroutine(Release());
	}

	IEnumerator Release()
	{
		yield return new WaitForSeconds(releaseTime);

		GetComponent<SpringJoint2D>().enabled = false;
		this.enabled = false;

		yield return new WaitForSeconds(2f);

		if (nextBall != null)
		{
			nextBall.SetActive(true);
		}
		else
		{
			Enemy.EnemiesAlive = 0;
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}

	}

}
