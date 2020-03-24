using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpd=10;
    public float jumpF=75;
    public float gScale = 0.75f;
    private Vector3 moveDir;
    public CharacterController controller;
    //public Rigidbody rBody;

    void Start(){
    	this.tag = "Player";
    	//rBody = this.GetComponent<Rigidbody>();
        controller = this.GetComponent<CharacterController>();
        //rBody.mass = 1;
    }

	void Update(){
		moveDir = new Vector3(Input.GetAxis("Horizontal")*moveSpd, 0, Input.GetAxis("Vertical")*moveSpd);
		//jump
		if(Input.GetButtonDown("Jump")){
			moveDir.y = jumpF;
		}
	moveDir.y = moveDir.y + Physics.gravity.y*gScale;
	controller.Move(moveDir*Time.deltaTime);

	}

}