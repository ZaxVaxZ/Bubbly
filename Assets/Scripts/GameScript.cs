using UnityEngine;

public class GameScript : MonoBehaviour
{
	public GameObject camera;
	public GameObject bubble;
	private Rigidbody2D	player_rigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
		player_rigidbody = bubble.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        camera.transform.Translate(Vector3.up * 0.05f);
        bubble.transform.Translate(Vector3.up * 0.05f);
		player_rigidbody.linearVelocity = new Vector2(0f, Vector2.up.y * 0.05f);
		if (Input.GetKey(KeyCode.W) && bubble.transform.position.y < camera.transform.position.y - 2)
		{
        	bubble.transform.Translate(Vector3.up * 2f * Time.deltaTime);
			player_rigidbody.linearVelocity = new Vector2(0f, Vector2.up.y * 2f * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.A) && bubble.transform.position.x > camera.transform.position.x - 3)
		{
        	bubble.transform.Translate(Vector3.left * 2f * Time.deltaTime);
			player_rigidbody.linearVelocity = new Vector2(Vector2.left.x * 2f * Time.deltaTime, 0f);
		}
		if (Input.GetKey(KeyCode.S) && bubble.transform.position.y > camera.transform.position.y - 4)
		{
        	bubble.transform.Translate(Vector3.down * 2f * Time.deltaTime);
			player_rigidbody.linearVelocity = new Vector2(0f, Vector2.down.y * 2f * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.D) && bubble.transform.position.x < camera.transform.position.x + 3)
		{
        	bubble.transform.Translate(Vector3.right * 2f * Time.deltaTime);
			player_rigidbody.linearVelocity = new Vector2(Vector2.right.x * 2f * Time.deltaTime, 0f);
		}
    }
}
