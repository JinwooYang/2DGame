using UnityEngine;
using System.Collections;

public class Missile : MonoBehaviour 
{
    public Rigidbody2D rig = null;

	void Start () 
    {
        rig.velocity = Vector2.up * 5f;
	}
	
	void Update () 
    {
	
	}
}
