using UnityEngine;
using System.Collections;

public class PlayerState : MonoBehaviour 
{
    public UILabel goldLabel = null;
    public UILabel killLabel = null;
    public UILabel scoreLabel = null;

    int goldCount = 0;
    int killCount = 0;
    int scoreCount = 0;

    bool isDie = false;

	void OnTriggerEnter2D(Collider2D other)
    {
        int layerIndex = other.gameObject.layer;
        if(layerIndex == LayerMask.NameToLayer("Gold"))
        {
            ++goldCount;
            goldLabel.text = "Gold : " + goldCount;
            Destroy(other.gameObject);
        }
        else if (layerIndex == LayerMask.NameToLayer("Monster"))
        {
            isDie = true;
            //Application.LoadLevel("Result");
        }

    }

    public void AddKillCount()
    {
        ++killCount;
        killLabel.text = killCount + " : Kill";
    }

    void Update()
    {
        if(isDie)
        {
            PlayerPrefs.SetInt("Score", scoreCount);
            Application.LoadLevel("Result");
            return;
        }

        scoreCount = goldCount + killCount;
        scoreLabel.text = "Score : " + scoreCount;
    }
}
