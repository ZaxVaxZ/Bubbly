using UnityEngine;

public class cam_scroll : MonoBehaviour
{
    public GameObject   cam;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cam.transform.Translate(Vector3.up * 0.2F);
        // float tempX = cam.transform.position.x;
        // float tempY = cam.transform.position.y;
        // cam.transform.position = new Vector3(tempX, tempY = 0.2F, 0F);
        // cam.transform.position.y += 0.2;
    }
}
