using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundPoint : MonoBehaviour
{
    
    public float speed  ;
    public float Radius ;
    public float angle ;
    public bool paused =false ;
    public  bool sag,sol ;
    //public Transform lookAtTarget;   
    void Start()
    {
      speed = 0.5f;
      Radius =50f;
       angle =10 ;
       sag =false ;
       sol = false ;
    }

    // Update is called once per frame
    void Update()
    {
        if(paused == false)
        {
         angle +=speed * Time.deltaTime;
         Vector3 newPos = new Vector3(Mathf.Sin(angle), 0f,Mathf.Cos(angle)) * Radius;
         transform.position = Vector3.Lerp(transform.position, newPos, Time.deltaTime * speed); //
         
          Quaternion rotation = Quaternion.LookRotation(newPos, Vector3.up);
        transform.rotation = rotation;
        Debug.Log(Radius);
        }
    }
    void FixedUpdate()
    {
     
       
    }
    public void RotateAuto(float radius)
    {
      
      if((Radius + radius) <= 20)
      {
        Radius = 20 ;
      }
      else if ((Radius + radius) >= 90)
      {
        Radius = 90 ;
      }
      else 
      Radius += radius;

      


    }
}
