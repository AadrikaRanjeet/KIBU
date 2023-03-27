using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
   public float Damage =1f;
   [SerializeField] float Range=1000f;
   public GameObject gun;
   target Target;
    RaycastHit hitinfo;// stores info abt the object which we hit 
    public ParticleSystem muzzleflash;
    AudioSource audio;
   

    void Start()
   {
     audio=GetComponent<AudioSource>();
   }
    void Update()
    {
      
      if(Input.GetMouseButtonDown(0))
      {
         Shooting();
           audio.Play();
         
      }
    }
    void Shooting()
    {
     muzzleflash.Play();
      
    if(Physics.Raycast(gun.transform.position,gun.transform.forward,out hitinfo ,Range))
     {
      
     Target= hitinfo.transform.GetComponent<target>();//find the target component on the object that we hit
     //Target=GameObject.FindGameObjectWithTag("gun").GetComponent<target>();
     
      if(Target !=null)
      {
         StartCoroutine(TakeTime());
       
        Debug.Log(hitinfo.transform.name);
      }
      if(hitinfo.rigidbody !=null)
      {
        hitinfo.rigidbody.AddForce(hitinfo.normal);
      }

     }
    }
     IEnumerator TakeTime()
   {
      yield return new WaitForSeconds(1f);
       Target.TakeDamage(Damage);
   }
}
