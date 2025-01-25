using UnityEngine;

public class EnemyMove : MonoBehaviour
{
	public bool	left_to_right = true;
	public int	move_speed = 8;
	public int	third = 1;
	public GameObject bubble;
	public GameObject camera;
	private float height_step;
	private float upwards;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
		upwards = 0.02f;
		height_step = 4.8f;
        if (third == 2)
		{
			height_step = 2.4f;
			upwards = 0.035f;
		}
		else if (third == 3)
		{
			height_step = -1.5f;
			upwards = 0.05f;
		}
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y <= camera.transform.position.y + height_step)
		{
			Debug.Log(move_speed);
			if (left_to_right)
				gameObject.transform.Translate((Vector3.right * move_speed) * 0.001f);
			else
				gameObject.transform.Translate((Vector3.left * move_speed) * 0.001f);
			gameObject.transform.Translate(Vector3.up * upwards);
		}
		if (gameObject.transform.position.y < camera.transform.position.y - 6)
		{
			Destroy(gameObject);
		}
    }
}
