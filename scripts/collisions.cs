
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisions : MonoBehaviour
{
public playerMovment movment;
public ConstantForce force;
public Transform player;
public Vector3 rotationoffset;

void OnCollisionEnter (Collision collisionInfo){

if(collisionInfo.collider.tag=="Obstacle"){
    Debug.Log("we hit the obstacle");
    movment.enabled= false;
    force.enabled=false;
    FindObjectOfType<GameManager>().EndGame();
   
}
if(collisionInfo.collider.tag=="ramp"){

    Debug.Log("we hit a ramp");
    player.Rotate(rotationoffset*Time.deltaTime);
    
}

if(collisionInfo.collider.tag=="partyball"){

    Debug.Log("Level Complete");
}

}

}
