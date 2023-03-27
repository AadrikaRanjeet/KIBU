using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private Animator anim;
    public  float Runspeed;
    
 //   [SerializeField] CharacterController controller;
    
    // Start is called before the first frame update
    void Start()
    {
        anim=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
     
     //  float horizontal=Input.GetAxis("Vertical");
     if(Input.GetAxis("Vertical")>0)
     {
         anim.SetBool("run",true);
         transform.Translate(0,0,1*Runspeed*Time.deltaTime);

          //Debug.Log(horizontal);
     }
     if(Input.GetAxis("Vertical")==0)
     {
         anim.SetBool("run",false);
           
          //Debug.Log(horizontal);
     }
      if(Input.GetAxis("Vertical")<0)
     {
         anim.SetBool("run",true);
          //Debug.Log(horizontal);
           transform.Translate(0,0,-1*Runspeed*Time.deltaTime);
     }
      if(Input.GetKeyDown(KeyCode.Space))
      {
        anim.SetTrigger("slide");
      } 
    }
}
