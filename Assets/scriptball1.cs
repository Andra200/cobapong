using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptball1 : MonoBehaviour
{
    //public int speed = 30;

    public Rigidbody2D sesuatu;

public Animator animtr;
    // Start is called before the first frame update
    void Start()
    { 
        int x = Random.Range(0, 2)*2 - 1;
        int y = Random.Range(0, 2)*2 - 1;
        int speed = Random.Range(20, 26);
        sesuatu.velocity = new Vector2 (x,y) * speed;
        sesuatu.GetComponent<Transform>().position = Vector2.zero;
        animtr.SetBool("IsMove", true);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(sesuatu.velocity.x > 0){ //bola bergerak kekanan
            sesuatu.GetComponent<Transform>().localScale = new Vector3(1 , 1, 1);
        }else{
            sesuatu.GetComponent<Transform>().localScale = new Vector3(-1 , 1, 1);
        }
    }

    void OnCollisionEnter2D(Collision2D other) {
        if(other.collider.name=="DindingKanan"||other.collider.name=="DindingKiri"){
           StartCoroutine(jeda());
        }    
    }

    IEnumerator jeda(){
        sesuatu.velocity = Vector2.zero;
        animtr.SetBool("IsMove", false);
        sesuatu.GetComponent<Transform>().position = Vector2.zero;
        yield return new WaitForSeconds(1);

        int x = Random.Range(0, 2)*2 - 1;
        int y = Random.Range(0, 2)*2 - 1;
        int speed = Random.Range(20, 26);
        sesuatu.velocity = new Vector2 (x,y) * speed;
        animtr.SetBool("IsMove", true);
    }
}
