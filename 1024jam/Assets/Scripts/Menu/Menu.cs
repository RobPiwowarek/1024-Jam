using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

    public bool isQuitButton = false;
    public bool isPlayButton = false;
    public bool isOptionsButton = false;
    public bool isCreditsButton = false;

    void OnMouseOver()
    {
        GetComponent<TextMesh>().color = new Color(255, 0, 0);
    }

    void OnMouseExit() {
        GetComponent<TextMesh>().color = new Color(255, 255, 255);
    }

    void OnMouseUp()
    {
        if (isQuitButton)
            Application.Quit();
        else if (isPlayButton)
            Application.LoadLevel(1);
        else if (isOptionsButton) ;
        else if (isCreditsButton) ;

    }
}
