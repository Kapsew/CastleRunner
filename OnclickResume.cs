using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ;

public class OnclickResume : MonoBehaviour
{
   public GameObject resume_ =null ;
  public Button ResumeButton ;  



   void Start()
    {
        Button btn = ResumeButton.GetComponent<Button>();
	      btn.onClick.AddListener(TaskOnClick);
    }

void TaskOnClick()
{

    ResumeGame();


}

void ResumeGame()
  { 
       resume_.SetActive(false);
       
       GameObject.Find("Main Camera").GetComponent<SpawnTile>().isSpawn=true;
       GameObject.Find("Score_text").GetComponent<Score>().keepScore=true;
       //GameObject.Find("PlayerEx").GetComponent<Rigidbody>().transform.position += new Vector3(0f,0.2f,0f) ;
       GameObject.Find("Sphere").GetComponent<RotateAroundPoint>().paused=false ;

           
     
      

  }



}
