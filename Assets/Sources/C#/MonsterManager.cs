using UnityEngine;
using System.Collections;

public class MonsterManager : MonoBehaviour 
{
    public GameObject monster = null;

    float interval = 0f;
    float intervalMax = 3f;

	
	void Update () 
    {
        interval += Time.deltaTime;

        if(interval > intervalMax)
        {
            interval = 0f;

            float startX = -2f;
            for (int i = 0; i < 5; ++i)
            {
                GameObject obj = Instantiate(monster);
                obj.transform.position = new Vector2(startX, 4.5f);
                ++startX;
            }
        }
	}
}
