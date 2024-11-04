using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackImmunity : MonoBehaviour
{
    Renderer rend;
    Color c;
    public int immunityTime;
    bool attack = true;

    void Start()
    {
        rend = gameObject.GetComponent<Renderer>();
        c = rend.material.color;
    }
    IEnumerator Immunity() {
        Debug.Log("Coroutine started");
        attack = false;
        //Physics2D.IgnoreLayerCollision(0, 0, true);
        c.a = 0.5f;
        rend.material.color = c;
        yield return new WaitForSeconds(immunityTime);
        //Physics2D.IgnoreLayerCollision(0, 0, false);
        c.a = 1f;
        rend.material.color = c;
        Debug.Log("End of coroutine");
        attack = true;
    }

    public bool GetAttackBool()
    {
        return attack;
    }
}
