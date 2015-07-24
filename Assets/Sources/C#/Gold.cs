using UnityEngine;
using System.Collections;

public class Gold : MonoBehaviour 
{
    Rigidbody2D rig;


    void Start () 
    {
        rig = GetComponent<Rigidbody2D>();
        float x = Random.Range(-1.5f, 1.5f);
        rig.velocity = new Vector2(x, 2f);
	}
	
}
