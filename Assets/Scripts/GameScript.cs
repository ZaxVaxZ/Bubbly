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
        camera.transform.Translate(Vector3.up * 0.1f);
        bubble.transform.Translate(Vector3.up * 0.1f);
		if (Input.GetKeyDown (KeyCode.A))
		{
        	bubble.transform.Translate(Vector3.left * 0.1f);
		}
		if (Input.GetKeyDown (KeyCode.D))
		{
        	bubble.transform.Translate(Vector3.right * 0.1f);
		}
    }
}
