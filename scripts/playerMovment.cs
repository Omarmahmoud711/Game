using UnityEngine;


public class playerMovment : MonoBehaviour
{

public float forwardforce=700f;
public float force=700f;
public Rigidbody rb;
public bool onGround=true;
public playerMovment pm;
public score sc;
public GameObject felloff;


    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void FixedUpdate()
    {   rb.AddForce(0,0,forwardforce*Time.deltaTime,ForceMode.VelocityChange);
        //rb.AddForce(0,0,forwardforce*Time.deltaTime);
        if(Input.GetKey("d")){
            rb.AddForce(force*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(Input.GetKey("a")){
            rb.AddForce(-force*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(Input.GetKey("w")&&onGround){

            rb.AddForce(0,10*force*Time.deltaTime,0,ForceMode.Impulse);
            onGround=false;
        }

        if(rb.position.y<0 && rb.position.z<350){
    felloff.SetActive(true);        
    FindObjectOfType<GameManager>().EndGame();
    pm.enabled=false;
    sc.enabled=false;
    

        }
    }

    void OnCollisionEnter(Collision collisionInfo){
   if(collisionInfo.collider.tag=="Ground" || collisionInfo.collider.tag=="ramp"){
onGround=true;

}
}
}
