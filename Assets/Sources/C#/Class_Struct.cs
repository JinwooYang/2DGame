using UnityEngine;
using System.Collections;

class VectorClass
{
    public float x, y;
}

struct VectorStruct
{
    float x, y;
}


public class Class_Struct : MonoBehaviour 
{
	void Start () 
    {
        VectorClass vec = new VectorClass();
        vec.x = 100f;
        vec.y = 200f;
	}
	
	void Update () 
    {
	
	}
}
