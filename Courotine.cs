using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Courotine : MonoBehaviour
{
    public float time = 0.5f;

    public Vector3 endPos = new Vector3();

    private bool isLerping;
    //public Renderer renderer;
    
    //public Material material;

    // Start is called before the first frame update
    void Start()
    {
        //renderer = GetComponent<Renderer>();
        //material = GetComponent<Renderer>().material;
        //StartCoroutine(Coroutine());
    }

    private void Update()
    {
        if (Input.GetKey("space") && !isLerping)
        {
            isLerping = true;
            StartCoroutine(Coroutine());
        }
    }

    IEnumerator Coroutine()
    {

        Debug.LogWarning("Ik start nu de coroutine");


        transform.position = Vector3.Lerp(transform.position, endPos, time);

        if(transform.position == endPos)
        {
            yield return true;
            isLerping = false;
            Debug.LogWarning("coroutine einde");
        }
        else
        {
            yield return false;
            StartCoroutine(Coroutine());
        }

        Debug.Log("coroutine Bezig");

    }
}
