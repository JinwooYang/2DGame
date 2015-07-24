using UnityEngine;
using System.Collections;

public class MissileProcess : MonoBehaviour
{
    public GameObject missile = null;
    public Transform missileSpawnTransform = null;

    float interval = 0f;
    float intervalMax = 0.1f;

    void Update()
    {
        interval += Time.deltaTime;

        if (interval > intervalMax)
        {
            interval = 0f;

            Instantiate(missile, missileSpawnTransform.position, Quaternion.identity);
        }
    }
}
