using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    public float velocidade;
    public GameObject prefabBala;

    void FixedUpdate() {
    float h = Input.GetAxis("Horizontal");
    float v = Input.GetAxis("Vertical");
    Rigidbody2D r = this.GetComponent<Rigidbody2D>();
    r.velocity = new Vector3(h,0,0) * velocidade;
}

void Update() {
if(Input.GetKeyDown(KeyCode.Space)) {
Vector3 pos = this.transform.position;
Instantiate(prefabBala, pos, Quaternion.Euler(0,0,270));
}
}




}
