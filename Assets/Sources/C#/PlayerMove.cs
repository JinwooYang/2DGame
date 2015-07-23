using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour 
{
    public float speed = 5f;

    Transform cachedTransform;

    void Awake() 
    {
        cachedTransform = base.transform;
	}
	
	void Update () 
    {
        float dirX = Input.GetAxis("Horizontal");
        float velocityX = dirX * speed * Time.deltaTime;

        float dirY = Input.GetAxis("Vertical");
        float velocityY = dirY * speed * Time.deltaTime;

        cachedTransform.Translate(velocityX, velocityY, 0);
	}
}
