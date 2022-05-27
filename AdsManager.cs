using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements ; 

public class AdsManager : MonoBehaviour , IUnityAdsListener
{

  
#if UNITY_IOS
   string gameId = "4688416";
#else 
    string gameId = "4688417";
#endif


    void Start()
    {
        Advertisement.Initialize(gameId); 
        Advertisement.AddListener(this);

    }

   public void PlayAd(){
       if(Advertisement.IsReady("Interstitial_Android")){
           Advertisement.Show("Interstitial_Android");
       }
   }
   public void PlayRewardedAd(){
       if(Advertisement.IsReady("Rewarded_Android")){
           Advertisement.Show("Rewarded_Android");
       }
       else {
           Debug.Log("Rewarded ad is not ready !!");
       }
   }
public void OnUnityAdsReady(string placementid)
{
    Debug.Log("Ads are ready !!");
}
public void OnUnityAdsDidError(string message)
{
Debug.Log("Error : " + message);
}
public void OnUnityAdsDidStart(string placementid)  
{
 Debug.Log("Video started");
}
public void OnUnityAdsDidFinish(string placementid ,ShowResult showResult)
{
   if(placementid == "Rewarded_Android" && showResult == ShowResult.Finished){
       Debug.Log("Player Should be Rewarded !!");
   }
}
}
