using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //public float forceMultiplier= 3f;
    //public float maximumVelocity= 3f;
    //private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        //rb=GetComponent<Rigidbody>(); //Cashing
    }

    public float velocidade = 5f;
    void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * velocidade * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * velocidade * Time.deltaTime);
        }

    }

    /* Update is called once per frame
    void Update()
    {
        var horizontalInput= Input.GetAxis("Horizontal"); 

        if(rb.velocity.magnitude <= maximumVelocity){
            rb.AddForce(new Vector3(horizontalInput*forceMultiplier,0,0));
        }
    }*/

    private void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.CompareTag("Hazard"))
        {
            Destroy(gameObject);
        }
    }
}
