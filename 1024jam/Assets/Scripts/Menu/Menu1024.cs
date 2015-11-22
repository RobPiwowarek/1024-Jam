using UnityEngine;
using System.Collections;

public class Menu1024 : MonoBehaviour {

    void OnMouseEnter()
    {
        GetComponent<AudioSource>().Play();
        GetComponent<SpriteRenderer>().color = new Color(255, 0, 0);
    }

    void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().color = new Color(255, 255, 255);
    }
}
