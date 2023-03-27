using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Name
{
public class targetforenemy : MonoBehaviour
{
   public float health =80f;
   public float amount;
   public ParticleSystem boom;
    void Update()
   {
      
      TakeDamage(amount);
   }
   public void TakeDamage(float amount)
   {
      
      if(health <=0)
      {
         boom.Play();
         Die();
      }
      Debug.Log(health);
      StartCoroutine(DelayTime());
   }
   void Hit()
   {
      if(Input.GetMouseButtonDown(0))
      {
         health -=amount;
      }
   }
   public void Die() 
   {
   
        Destroy(gameObject);
   }
  IEnumerator DelayTime()
    {
      yield return new WaitForSeconds(0.1f);
       Hit();
    }
    
}
}