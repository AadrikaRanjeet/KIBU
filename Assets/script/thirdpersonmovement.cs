using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thirdpersonmovement : MonoBehaviour
{
    public movement script;//accessing movement script in order to access its variable.
    public CharacterController controller;
    public Transform cam;
    [SerializeField] float speed ;
    float turnSmoothVelocity;
    float turnSmoothTime= 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      float h =Input.GetAxis("Horizontal");
      float v =Input.GetAxis("Vertical"); 
      Vector3 direction= new Vector3(h,0,v);
      if(direction.magnitude >=0.1f)
      {
        float TargetAngle =Mathf.Atan2(direction.x, direction.y)*Mathf.Rad2Deg + cam.eulerAngles.y;
        float angle =Mathf.SmoothDampAngle(transform.eulerAngles.y,TargetAngle,ref turnSmoothVelocity,turnSmoothTime);
        transform.rotation =Quaternion.Euler(0f,angle,0f);
        Vector3 moveDir =Quaternion.Euler(0f,TargetAngle,0f)*Vector3.forward;
        if(Input.GetAxis("Vertical")>0)
     {
        controller.Move(moveDir*speed*Time.deltaTime);
     }
         if(Input.GetAxis("Vertical")<0)
     {
          moveDir =Quaternion.Euler(0f,TargetAngle,0f)*Vector3.forward;
        controller.Move(moveDir*-speed*Time.deltaTime);
     }
      }
    }
}
