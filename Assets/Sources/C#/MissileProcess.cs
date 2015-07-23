using UnityEngine;
using System.Collections;

public class MissileProcess : MonoBehaviour 
{
    public GameObject missile = null;

    Transform cachedTransform;

    float interval = 0f;
    float intervalMax = 0.1f;

	void Awake () 
    {
        cachedTransform = base.transform;
	}
	
	void Update () 
    {
	    interval += Time.deltaTime;

        if(interval > intervalMax)
        {
            interval = 0f;

            Instantiate(missile, cachedTransform.position, Quaternion.identity);
        }
	}
}
