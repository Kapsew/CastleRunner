using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
     public float speed  ;
    public float Radius ;
    public float angle ;
    public bool GameOn = true ; 
    void Start()
    {
        speed = 0.5f;
      Radius = 40f;
       angle =10 ;
    }

    // Update is called once per frame
    void Update()
    {
        MovewithCircular();
    }
    public void MovewithCircular()
    {

         if(GameOn == true)
        {
         angle -=speed * Time.deltaTime;
         Vector3 newPos = new Vector3(Mathf.Sin(angle), 0f,Mathf.Cos(angle)) * Radius;
         this.transform.position = Vector3.Lerp(this.transform.position, newPos, Time.deltaTime ); //
        Debug.Log(Radius);
        }
    }
}
