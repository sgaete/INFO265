using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
	public Transform camTransform;

	public float distance = 5.0f;
	public float currentX = 0.0f;
	public float currentY = 0.0f;
	public float sensX = 20.0f;
	public float sensY = 5.0f;
	public const float Y_MIN_ANGLE =0.0f;
	public const float Y_MAX_ANGLE =50.0f;
	
	    // Start is called before the first frame update
    void Start()
    {	


        //print(GameObject.FindWithTag("Player").transform.position.x);
	    //this.enabled = true;
		//this.transform.position = new Vector3(0,1,-5);
		//this.transform.rotation = Quaternion.Euler(15,0,0);
		camTransform = this.transform;
    }

    void Update(){
    	//currentX += Input.GetAxis("Mouse X");
    	currentY += Input.GetAxis("Mouse Y")*2;
    	currentY = Mathf.Clamp(currentY, Y_MIN_ANGLE,Y_MAX_ANGLE);
    }
    void LateUpdate(){
    	Vector3 lookAt = GameObject.FindWithTag("Player").transform.position;
    	Vector3 dir = new Vector3(0 ,0 ,-distance);
    	Quaternion rot = Quaternion.Euler(0,currentY,0);
    	Vector3 prod = new Vector3(0, rot.y*sensY, dir.z);
    	camTransform.position = lookAt + prod;
    	camTransform.LookAt(lookAt);
    }
}
