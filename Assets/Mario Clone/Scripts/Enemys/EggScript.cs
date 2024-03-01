using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggScript : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == MyTags.PLAYER_TAG)
        {
            target.gameObject.GetComponent<Damage>().DealDamage();
        }
        gameObject.SetActive(false);
    }
}
