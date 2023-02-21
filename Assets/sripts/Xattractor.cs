using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Xattractor : MonoBehaviour
{
    static public Vector3 POS = new Vector3(0, 0, 0);
    public float speed;
    public float r;
    public float Xpos;
    public float Ypos;
    public float Zpos;
    public float ct;

    
    void Update()
    {

        Vector3 tPos = new Vector3(Xpos, Ypos, Zpos);
        Vector3 scale = transform.localScale;
        Xpos = Mathf.Cos (ct) * r;
       Zpos = Mathf.Sin(ct) * r;
        
        //Zpos = speed * Time.deltaTime;

        transform.position = new Vector3(Xpos, Ypos, Zpos);

        ct += Time.deltaTime * speed;
        transform.position = tPos;
        POS = tPos;




    }
}
