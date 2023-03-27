using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyInstantiate : MonoBehaviour
{
    [SerializeField] GameObject enemy;
   // [SerializeField] GameObject enemy1;
    [SerializeField] float xPos;
    [SerializeField] float zPos;
    [SerializeField] float yPos;
    [SerializeField] float TotalSpawn;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemySpawn());
    }

    IEnumerator EnemySpawn()
    {
        while(TotalSpawn >0)
        {
            xPos=Random.Range(-15,2);//xposition jahaa enemy ko spwan karana hai
            zPos=Random.Range(-1,10);// zpositon jahaa enemy ko spawn karana hai
            Instantiate(enemy,new Vector3(xPos,yPos,zPos),Quaternion.identity);//spwaning
            yield return new WaitForSeconds(0.2f);
            TotalSpawn--;
        }
    }
}
