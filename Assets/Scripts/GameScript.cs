using UnityEngine;

public class GameScript : MonoBehaviour
{
	public GameObject camera;
	public GameObject bubble;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        camera.transform.Translate(Vector3.up * 0.05f);
        bubble.transform.Translate(Vector3.up * 0.05f);
		if (Input.GetKey(KeyCode.W) && bubble.transform.position.y < camera.transform.position.y - 2)
		{
        	bubble.transform.Translate(Vector3.up * 2f * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.A) && bubble.transform.position.x > camera.transform.position.x - 3)
		{
        	bubble.transform.Translate(Vector3.left * 2f * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.S) && bubble.transform.position.y > camera.transform.position.y - 4)
		{
        	bubble.transform.Translate(Vector3.down * 2f * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.D) && bubble.transform.position.x < camera.transform.position.x + 3)
		{
        	bubble.transform.Translate(Vector3.right * 2f * Time.deltaTime);
		}
    }
}
