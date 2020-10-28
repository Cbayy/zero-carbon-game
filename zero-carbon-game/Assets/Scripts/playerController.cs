using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    float speed = 5;
    //Vector3 targetPosition;
    //bool isMoving = false;

    public Rigidbody2D rb;
    private Vector2 moveDirection;
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        /*
        if(Input.GetMouseButton(0)){
            setTargetPosition();
        }
        if(isMoving){
            move();
        }
        */
        ProcessInputs();
    }
    

    void FixedUpdate(){
        Move();
    }

    void ProcessInputs(){
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized;
    }

    void Move(){
        rb.velocity = new Vector2(moveDirection.x * speed, moveDirection.y * speed);
        
        Vector3 characterScale = transform.localScale;
        if(Input.GetAxis("Horizontal") < 0){
            animator.SetBool("left", true);
            animator.SetBool("right", false);
            animator.SetBool("idle", false);
            animator.SetBool("up", false);
            animator.SetBool("down", false);
        }
        if(Input.GetAxis("Horizontal") > 0){
            animator.SetBool("right", true);
            animator.SetBool("left", false);
            animator.SetBool("idle", false);
            animator.SetBool("up", false);
            animator.SetBool("down", false);
        }
        if(Input.GetAxis("Horizontal") == 0){
            animator.SetBool("right", false);
            animator.SetBool("left", false);
            animator.SetBool("idle", true);
            animator.SetBool("up", false);
            animator.SetBool("down", false);
        }
        if(Input.GetAxis("Vertical") > 0){
            animator.SetBool("right", false);
            animator.SetBool("left", false);
            animator.SetBool("idle", false);
            animator.SetBool("up", true);
            animator.SetBool("down", false);
        }
        if(Input.GetAxis("Vertical") < 0){
            animator.SetBool("right", false);
            animator.SetBool("left", false);
            animator.SetBool("idle", false);
            animator.SetBool("up", false);
            animator.SetBool("down", true);
        }
    }

    /*
    void setTargetPosition(){
        targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        targetPosition.z = transform.position.z;
        isMoving = true;
    }

    void move(){
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        if(transform.position == targetPosition){
            isMoving = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other){
        print("yeet");
        if(other.gameObject.CompareTag("items")){
            Destroy(other.gameObject);
        }
    }
    */

}
