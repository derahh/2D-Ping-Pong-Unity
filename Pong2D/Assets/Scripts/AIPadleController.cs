using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPadleController : MonoBehaviour
{
    public float kecepatan;
    public float batasAtas;
    public float batasBawah;
    public GameObject Ball;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
       
        if (Ball.transform.position.y > transform.position.y && transform.position.y < batasAtas)
        {
            transform.Translate(Vector3.up * kecepatan * Time.deltaTime);
        }
        if (Ball.transform.position.y < transform.position.y && transform.position.y > batasBawah)
        {
            transform.Translate(Vector3.down * kecepatan * Time.deltaTime);
        }

   
    }
}
