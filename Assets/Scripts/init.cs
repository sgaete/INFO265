using UnityEngine;
using System.Collections;
using UnityEditor;

public class init : MonoBehaviour
{
    Camera mCamera;
	Material m_Material;
	Renderer m_ObjectRenderer;
	public GameObject pollito;

    void Start()
    {
    	//crear script de camara
    	Object obj = Resources.Load("Meshs/pollito") as GameObject;
        pollito = Instantiate(obj) as GameObject;
        pollito.AddComponent<CharacterController>();
        pollito.transform.position=new Vector3(0,0.4f,0);
        pollito.transform.localScale=new Vector3(5, 5, 10);
        pollito.transform.eulerAngles=new Vector3(0,90,90);
        pollito.AddComponent<character>();


        //crear script de escenario
	    GameObject plane  = GameObject.CreatePrimitive(PrimitiveType.Plane);
	    plane.transform.Translate(0, 0, 0);
	    m_ObjectRenderer = plane.GetComponent<Renderer>();
	    Material myMaterial=Resources.Load<Material>("Materials/Floor001");
	    myMaterial.SetTextureScale("_MainTex", new Vector2(10, 10));
	    m_ObjectRenderer.material=myMaterial;

	    //crear script de personaje
	    
	    obj = Resources.Load("Meshs/plain_tree") as GameObject;
        //Debug.Log("Loaded from Resources: " + obj); 
        GameObject arbol = Instantiate(obj) as GameObject;
        arbol.transform.position=new Vector3(-2,0.5f,3);
        arbol.transform.localScale=new Vector3(30, 30, 50);
        arbol.transform.eulerAngles=new Vector3(-90,0,0);


  	    mCamera = Camera.main;
  	    mCamera.gameObject.AddComponent<ThirdPersonCamera>();
		
	    
        //Debug.Log("Instantiated: " + go);
        


	    //crear script de enemigo

	    //crear script de logica vida muerte
	    
        

    }


}