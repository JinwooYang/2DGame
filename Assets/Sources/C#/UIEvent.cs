using UnityEngine;
using System.Collections;

public class UIEvent : MonoBehaviour 
{
    public void ToGame()
    {
        Application.LoadLevel("Game");
    }

    public void ToTitle()
    {
        Application.LoadLevel("Title");
    }
}
