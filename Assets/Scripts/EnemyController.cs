using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 1.0f;
    public bool isVertical;
    public float changeTime = 2.0f;

    Rigidbody2D rb;
    float timer;
    int direction = 1;

    Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();    
        timer = changeTime;
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if(timer < 0){
            direction = -direction;
            timer = changeTime;
        }
        Vector2 pos = rb.position;

        if(isVertical){
            pos.y = pos.y + Time.deltaTime * speed * direction;
            anim.SetFloat("move.x",0);
            anim.SetFloat("move.y",direction);
        } else{
            pos.x = pos.x + Time.deltaTime * speed * direction;
            anim.SetFloat("move.x",direction);
            anim.SetFloat("move.y",0);
        }
        rb.MovePosition(pos);        
    }
    void OnCollisionEnter2D(Collision2D other){
        RubyController rubyCon = other.gameObject.GetComponent<RubyController>();
        if(rubyCon != null){
            rubyCon.Changehealth(-1);
        }
    }

}
