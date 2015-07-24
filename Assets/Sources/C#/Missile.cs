using UnityEngine;
using System.Collections;

public class Missile : MonoBehaviour 
{
    Rigidbody2D rig;

	void Start () 
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = Vector2.up * 5f;
	}
	
	void Update () 
    {
	
	}
}
