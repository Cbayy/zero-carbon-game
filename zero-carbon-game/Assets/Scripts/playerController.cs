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
