using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HealthCollectable : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        // Debug.Log("triggerと接触:" + other);        
        RubyController rubyCon = other.GetComponent<RubyController>();
        if(rubyCon != null){
            if(rubyCon.health == rubyCon.maxHealth){return;}
            transform.DOMoveY(transform.position.y + 1.5f,1f)
            .OnComplete(()=>Destroy(gameObject));
            rubyCon.Changehealth(1);
        }
    }
}
