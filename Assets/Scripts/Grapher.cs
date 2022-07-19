using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grapher : MonoBehaviour
{
    public Transform Line;
    public float DomainMin;
    public float DomainMax;
    public float Step;
    // Start is called before the first frame update
    void Start()
    {
        if (DomainMax<DomainMin) {
            float temp = DomainMax;
            DomainMax = DomainMin;
            DomainMin = temp;
        }
        float i = DomainMin;
        while (i<=DomainMax) {
            Vector3 v = new Vector3(i,functionToGraph(i),0);
            Instantiate(Line, v, new Quaternion(0,0,0,0));
            i+=Step;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public float functionToGraph(float x) {
        //float y = Mathf.Pow(x,2);
        float y = 3*x;
        //y = y / (2*x);
        return (y);
    }
}
