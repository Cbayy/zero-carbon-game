using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    float speed = 5;
    Vector3 targetPosition;
    bool isMoving = false;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0)){
            setTargetPosition();
        }
        if(isMoving){
            move();
        }
    }

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

}
