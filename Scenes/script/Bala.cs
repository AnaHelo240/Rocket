using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
   public GameObject explode; 

   void OnTriggerEnter2D(Collider2D col){

   if(col.name.StartsWith ("inimigo")) {
    Vector3 pos = col.transform.position;
    GameObject clone = (GameObject)Instantiate(explode, pos, Quaternion.identity);
    Destroy(col.gameObject);
    Destroy(this.gameObject);
    Destroy (clone, 0.5f); 
    }
    }
}
