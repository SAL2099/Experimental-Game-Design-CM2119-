using UnityEngine;

public class ControlsMenu : MonoBehaviour
{
    public GameObject controlMenu;

    public void OpenControls()
    {
        controlMenu.SetActive(true);
    }

    public void CloseControls()
    {
        controlMenu.SetActive(false);
    }

}
