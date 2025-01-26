using UnityEngine;

public class MusicControl : MonoBehaviour
{
	public AudioSource underwater;
	public AudioSource abovewater;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y > 150 && !abovewater.isPlaying)
		{
			Debug.Log("Playing");
			underwater.Stop();
			abovewater.Play();
		}
    }
}
