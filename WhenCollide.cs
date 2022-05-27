using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement ;

public class WhenCollide : MonoBehaviour
{

    
   void OnCollisionEnter(Collision other)
   {
       if(other.gameObject.tag == "Bullet")
       {
        
           Debug.Log("Box hitted !!");
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            GameObject.Find("Canvas").GetComponent<AdsManager>().PlayAd();
       }
   } 
   
}

