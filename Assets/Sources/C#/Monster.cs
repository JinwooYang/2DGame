using UnityEngine;
using System.Collections;


public class Monster : MonoBehaviour
{
    public Rigidbody2D rig = null;
    public Animator anim = null;
    public GameObject gold = null;

    bool isDamage = false;
    bool isDie = false;

    int hp = 5;

    void CreateGold()
    {
        GameObject obj = Instantiate(gold);
        obj.transform.position = this.transform.position;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (isDie || other.gameObject.layer != LayerMask.NameToLayer("Missile"))
            return;

        Destroy(other.gameObject);

        --hp;
        isDamage = true;
        anim.Play("MonsterDamage");

        if(hp <= 0)
        {
            isDie = true;
            anim.Play("MonsterDie");
        }
    }

    void ToIdle()
    {
        if (isDamage)
        {
            isDamage = false;
            return;
        }
        anim.Play("MonsterIdle");
    }

    void Die()
    {
        Destroy(this.gameObject);
    }

    void Start()
    {
        Vector2 velocity = rig.velocity;
        velocity.x = 0f;
        velocity.y = -2f;
        rig.velocity = velocity;
    }
}
