using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public float speed;
	public Text countText;
	public Text healthText;
	private Rigidbody rb;
	private int count;
	private int health;

	public Transform[] SpawnPoints;
	public float spawnTime = 1.5f;
	public GameObject PickUps;

	void Start()
	{
		rb = GetComponent<Rigidbody> ();
		count = 0;
		health = 5;
		SetCountText ();
		SetHealthText ();
	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag ("Pick Up"))
		{
			other.gameObject.SetActive (false);
			count = count+1;
			SetCountText();
		}

		if(other.gameObject.CompareTag ("Bullet"))
		{
			Destroy (other.gameObject);
			health = health-1;
			SetHealthText();
		}

		if (count == 5) {
			Winner ();
		}

		if (health == 0) {
			Loser ();
		}
	}

	void SetCountText()
	{
		countText.text = "Score: " + count.ToString ();
	}

	void SetHealthText(){
		healthText.text = "Health: " + health.ToString();
	}

	public void Winner(){
		Debug.Log ("WINNER...");
		Application.LoadLevel ("WinnerMenu");
	}

	public void Loser(){
		Debug.Log ("LOSER...");
		Application.LoadLevel ("GameOver");
	}
}
