using UnityEngine;
using System.Collections;
using UnityEditor;

public class init : MonoBehaviour
{
    Camera mCamera;
	Material m_Material;
	Renderer m_ObjectRenderer;
	public GameObject pollito;
	public GameObject key;


    void Start()
    {
    	//crear script de camara
    	Object obj = Resources.Load("Meshs/pollito") as GameObject;
        pollito = Instantiate(obj) as GameObject;
        pollito.AddComponent<CharacterController>();
        //pollito.AddComponent<Rigidbody>(); 
        pollito.transform.position=new Vector3(0.75f,2,-2.5f);
        pollito.transform.localScale=new Vector3(40, 40, 40);
        pollito.transform.eulerAngles=new Vector3(-90,180,0);
        pollito.AddComponent<BoxCollider>();
        pollito.AddComponent<character>();


        //crear script de escenario
	    GameObject plane  = GameObject.CreatePrimitive(PrimitiveType.Plane);
	    plane.transform.Translate(0, 0, 0);
	    m_ObjectRenderer = plane.GetComponent<Renderer>();
	    Material myMaterial=Resources.Load<Material>("Materials/Floor001");
	    myMaterial.SetTextureScale("_MainTex", new Vector2(10, 10));
	    m_ObjectRenderer.material=myMaterial;

	    obj = Resources.Load("Meshs/key2") as GameObject;
        key = Instantiate(obj) as GameObject;
        key.transform.position=new Vector3(3,0.75f,-4);
        key.transform.localScale=new Vector3(2, 5, 2);
        key.transform.eulerAngles=new Vector3(0,-180,0);
        key.AddComponent<BoxCollider>();


	    //crear script de personaje
	    
	    obj = Resources.Load("Meshs/plain_tree") as GameObject;
        //Debug.Log("Loaded from Resources: " + obj); 
        GameObject arbol = Instantiate(obj) as GameObject;
        arbol.transform.position=new Vector3(-2,0.5f,2);
        arbol.transform.localScale=new Vector3(30, 30, 50);
        arbol.transform.eulerAngles=new Vector3(-90,0,0);
        arbol.AddComponent<BoxCollider>();

  	    mCamera = Camera.main;
  	    mCamera.gameObject.AddComponent<ThirdPersonCamera>();
		
        

    }


}