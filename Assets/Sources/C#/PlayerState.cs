using UnityEngine;
using System.Collections;

public class PlayerState : MonoBehaviour 
{
	void OnTriggerEnter2D(Collider2D other)
    {
        int layerIndex = other.gameObject.layer;
        if(layerIndex == LayerMask.NameToLayer("Gold"))
        {
            Destroy(other.gameObject);
        }
        else if (layerIndex == LayerMask.NameToLayer("Monster"))
        {
            Application.LoadLevel("Result");
        }

    }

    void Start()
    {

    }

    void Update() 
    {
	
	}
}
