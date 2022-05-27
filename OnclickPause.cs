using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnclickPause : MonoBehaviour
{
   // RotateAuto rotateoto ;
    
    public GameObject paused_ =null;
    public Button yourButton ;
  
    
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        
	      	btn.onClick.AddListener(TaskOnClick);
          
    }
    void TaskOnClick()
    {
    
		   Debug.Log ("You have clicked the button!");
       
       
          PauseGame();
    
	  }


  void Update()
  {
    

  }


  void PauseGame()
  {
       
     
       GameObject.Find("Main Camera").GetComponent<SpawnTile>().isSpawn=false;
       GameObject.Find("Score_text").GetComponent<Score>().keepScore=false;
      GameObject.Find("Sphere").GetComponent<RotateAroundPoint>().paused=true;
       paused_.SetActive(true);    

     
      

  }

  


}
