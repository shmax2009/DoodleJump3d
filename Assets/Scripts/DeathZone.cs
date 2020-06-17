using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public GameObject Player;

    public void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "Player")
            Destroy(col.gameObject);
    }   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
