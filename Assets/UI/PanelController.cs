using UnityEngine;

public class PanelController : MonoBehaviour
{

    private void Awake()
    {
    }


    public void Disable()
    {
        gameObject.GetComponent<OptionMenuController>()?.UpdateSettings();
        gameObject.SetActive(false);
    }

    public void PlayClosingAnimation()
    {
        GetComponent<Animator>().SetBool("Close", true);
    }

}
