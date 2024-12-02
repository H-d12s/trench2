using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class divermove : MonoBehaviour
{
    public float moveForce = 3f;
    public float maxVelocity = 5f;
    private float movementX;
    private float movementY;
    private Rigidbody2D myBody;
    private SpriteRenderer sr;
    private Animator anim;
    private string WALK_ANIMATION = "swim"; 

    private void Awake(){
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        

    }

        void Start()
    {
        
    }

    void Update()
    {
       PlayerMoveKeyboard();
       AnimatePlayer();

    }

    void PlayerMoveKeyboard(){
        movementX = Input.GetAxisRaw("Horizontal");
        movementY =Input.GetAxisRaw("Vertical");
         if(Input.GetKey(KeyCode.LeftShift))
         {
            transform.position += new Vector3(movementX,movementY, 0f) * Time.deltaTime * maxVelocity;
         }
        else{
            transform.position += new Vector3(movementX,movementY, 0f) * Time.deltaTime * moveForce;
        }

    }

    void AnimatePlayer(){
        if(movementX>0){
        anim.SetBool(WALK_ANIMATION, true);
        sr.flipX = false;
        }
        else if(movementX<0){
            sr.flipX=true;
            anim.SetBool(WALK_ANIMATION,true);
        }
        else{
            anim.SetBool(WALK_ANIMATION,false);
        }
        if(movementY>0){
            sr.flipY=false;
            anim.SetBool(WALK_ANIMATION,false);
        }
        else if(movementY<0){
            
            sr.flipY=true;
            anim.SetBool(WALK_ANIMATION,false);}
        else
        {
            sr.flipY=false;
        }

        }
    }



