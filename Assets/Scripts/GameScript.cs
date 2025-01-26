using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour
{
	public GameObject camera;
	public GameObject bubble;
	public GameObject UI;
	public GameObject StartButton;
	public float	bubble_speed = 4f;
	public GameObject instructions;

	public bool		pause = false;
	public bool		stop = true;
	private float	speed;
	private Rigidbody2D	player_rigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
		player_rigidbody = bubble.GetComponent<Rigidbody2D>();
    }

	public void setStop(bool value)
	{
		stop = value;
	}

    // Update is called once per frame
    void Update()
    {
		if (camera.transform.position.y >= 290)
			return ;
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			pause = !pause;
			UI.SetActive(!UI.activeSelf);
			StartButton.SetActive(false);
		}
		if (stop || pause)
			return ;
		if (camera.transform.position.y < 15)
			speed = 0.02f;
		else if (speed < 0.05f)
			speed += 0.00005f;
		camera.transform.Translate(Vector3.up * speed);
        bubble.transform.Translate(Vector3.up * speed);
		player_rigidbody.linearVelocity = new Vector2(0f, Vector2.up.y * speed);
		if (camera.transform.position.y < 15)
			instructions.GetComponent<CanvasGroup>().alpha += 0.0005f;
		if (camera.transform.position.y < 15)
			return ;
		if (Input.GetKey(KeyCode.W) && bubble.transform.position.y < camera.transform.position.y - 2)
		{
        	bubble.transform.Translate(Vector3.up * bubble_speed * Time.deltaTime);
			player_rigidbody.linearVelocity = new Vector2(0f, Vector2.up.y * bubble_speed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.A) && bubble.transform.position.x > camera.transform.position.x - 7)
		{
        	bubble.transform.Translate(Vector3.left * bubble_speed * Time.deltaTime);
			player_rigidbody.linearVelocity = new Vector2(Vector2.left.x * bubble_speed * Time.deltaTime, 0f);
		}
		if (Input.GetKey(KeyCode.S) && bubble.transform.position.y > camera.transform.position.y - 4)
		{
        	bubble.transform.Translate(Vector3.down * bubble_speed * Time.deltaTime);
			player_rigidbody.linearVelocity = new Vector2(0f, Vector2.down.y * bubble_speed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.D) && bubble.transform.position.x < camera.transform.position.x + 7)
		{
        	bubble.transform.Translate(Vector3.right * bubble_speed * Time.deltaTime);
			player_rigidbody.linearVelocity = new Vector2(Vector2.right.x * bubble_speed * Time.deltaTime, 0f);
		}
    }
}
