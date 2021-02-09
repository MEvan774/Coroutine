using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Courotine : MonoBehaviour
{
    public float time = 0.5f;
    public Renderer renderer;
    //public Material material;

    // Start is called before the first frame update
    void Start()
    {
        //renderer = GetComponent<Renderer>();
        //material = GetComponent<Renderer>().material;
        StartCoroutine(Coroutine());
    }

    IEnumerator Coroutine()
    {

        Debug.LogWarning("Ik start nu de coroutine");
        //yield return new WaitForSeconds(time);

        for (float ft = 1f; ft >= 0; ft -= 0.1f)
        {


            Color c = renderer.material.color;

            //Color c = new Color(1,1,1,ft);
            c.a = ft;

            renderer.material.color = c;
            //renderer.material.SetColor("Color", c);
            //material.SetColor("color", c);


            //renderer.material.color = c;

            yield return new WaitForSeconds(time);
            //yield return null;
        }
        

        Debug.LogWarning("coroutine einde");
    }
}
