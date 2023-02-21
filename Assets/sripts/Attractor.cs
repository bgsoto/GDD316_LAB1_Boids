using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Attractor : MonoBehaviour
{
    static public Vector3 POS = new Vector3(0,0,0);

    [Header("Set in Inspector")]
    public float radius = 10.0f;
    public float xPhase = 0.5f;
    public float yPhase = 0.4f;
    public float zPhase = 0.1f;
    public float x = 0f;
    public float y = 0f;
    public float z = 0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // FiexedUpdate is called once per physics update (i.e. 50x/second)
    void FixedUpdate()
    {
        Vector3 tPos = new Vector3 (x,y,z);
        Vector3 scale = transform.localScale;
        tPos.x = Mathf.Sin(xPhase + Time.time) * radius * scale.x;
        tPos.y = Mathf.Cos(yPhase + Time.time) * radius * scale.y;
        tPos.z = Mathf.Sin(zPhase + Time.time) * radius * scale.z;
        tPos.z += 0.0f*Mathf.Sin(zPhase + 1.0f*Time.time) * radius * scale.z;
        transform.position = tPos;
        POS = tPos;
        
    }
}
