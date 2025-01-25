using UnityEngine;

public class player_collision : MonoBehaviour
{
	private Animator animator;    // Start is called once before the first execution of Update after the MonoBehaviour is created
	public GameObject scriptManager;
    void Start()
    {
		animator = GetComponent<Animator>();
        Debug.Log("Player collision script is active");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void    OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle") == true)
        {
            Debug.Log("Mr. Bubble hit an obstacle");
        }
    }

    private void    OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Exited the collider");
    }
    private void    OnTriggerEnter2D(Collider2D obstacle)
    {
        Debug.Log("On trigger for player is triggered\n");
		scriptManager.GetComponent<GameScript>()?.setStop(true);
		animator.SetBool("isDead", true);
    }
}
