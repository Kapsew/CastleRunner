using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    public Transform bulletSpawnPoint ;
    public GameObject bulletPrefab ;
    public float bulletspeed = 10.0f;
        public float timeOffset; //= 0.4f;
         private float startTime;
        
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
       
        
    }

    // Update is called once per frame
    void Update()

    { 
        
        if(Time.time - startTime > timeOffset)
    { 
        timeOffset = Random.Range(0.4f,8f);
        var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position,bulletSpawnPoint.rotation);
        //bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletspeed;
     
               startTime = Time.time;
    }
        
    }
    
}
