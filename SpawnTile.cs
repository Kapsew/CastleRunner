using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnTile : MonoBehaviour
{
     public bool isSpawn ;
    public Transform tileobj ;
   // public Vector3 nextoSpawn;
    private Vector3 nextTileSpawn ;
    private Vector3 spawnedObject ;
     public float timeOffset = 0.4f;
      private float startTime;

void Start()
     {    
         
          nextTileSpawn.x = 98.5f;
          nextTileSpawn.y =67.8f;   //93.4f ;   
          nextTileSpawn.z = 12.7f ;
          startTime = Time.time;
          isSpawn = true ;

     }

void Update()
{

if(isSpawn == true)
{
if (Time.time - startTime > timeOffset)
 {
     
     Instantiate(tileobj, nextTileSpawn, tileobj.rotation);
    nextTileSpawn.y +=  51.6f;//51.3f;


    //nextTileSpawn.y += 16.21f;

    startTime = Time.time;

 }

}
 
    
}

}
