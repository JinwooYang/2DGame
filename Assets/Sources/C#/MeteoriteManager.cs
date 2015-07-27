using UnityEngine;
using System.Collections;

public class MeteoriteManager : MonoBehaviour 
{
    IEnumerator Call()
    {
        //yield return 10;
        //print("Call 10");

        //yield return "10";
        //print("Call Unity");

        WaitForSeconds wait = new WaitForSeconds(5f);

        yield return wait;
        print("5 Call");

        yield return wait;
        print("5 Call");
    }

	// Use this for initialization
	void Start () 
    {
        //IEnumerator e = Call();
        //while(e.MoveNext())
        //{
        //    print("result" + e.Current);
        //}

        StartCoroutine(Call());
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}
}
