using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpd=10;
    public float jumpF=20;
    public CharacterController controller;
    private Vector3 moveDir;

    void Start(){
    	this.tag = "Player";
        controller = this.GetComponent<CharacterController>();
    }

	void Update(){
		moveDir = new Vector3(Input.GetAxis("Horizontal")*moveSpd, 0, Input.GetAxis("Vertical")*moveSpd);
		//jump
		if(Input.GetButtonDown("Jump")){
			moveDir.y = jumpF;
		}

	controller.Move(moveDir*Time.deltaTime);

	}




}



/*void Start()
    {

        this.tag = "Player";
        this.transform.position=new Vector3(0,0.5f,0);
        this.transform.localScale=new Vector3(5, 5, 10);
        this.transform.eulerAngles=new Vector3(0,90,90);
    }

    // Update is called once per frame
    void Update()
    {
		float vel = 0.05f;	
    	float gvel = 0.75f;
    	if (Input.GetAxis ("Horizontal")<0.0f)
		{
		    Vector3 position = this.transform.localPosition;
		    position.x-=vel;
		    this.transform.localPosition = position;
		}
		if (Input.GetAxis ("Horizontal")>0.0f)
		{
		    Vector3 position = this.transform.localPosition;
		    position.x+=vel;
		    this.transform.localPosition = position;
		}
		if (Input.GetAxis ("Vertical")>0.0f)
		{
		    Vector3 position = this.transform.localPosition;
		    position.z+=vel;
		    this.transform.localPosition = position;
		}
		if (Input.GetAxis ("Vertical")<0.0f)
		{
		    Vector3 position = this.transform.localPosition;
		    position.z-=vel;
		    this.transform.localPosition = position;
		}
        
    }*/