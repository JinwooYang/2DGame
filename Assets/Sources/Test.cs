using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour 
{
    public int a = 0;
    public float b = 0.12f;
    public string c = "유니티";
    public bool d = true;
    public Transform transform = null;

    void Start()
    {
        print("call");
    }

    void Update()
    {
        print("update");
    }
}
