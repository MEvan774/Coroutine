using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Courotine : MonoBehaviour
{
    public float time = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Coroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Coroutine()
    {

        Debug.LogWarning("Ik start nu de coroutine");
        yield return new WaitForSeconds(time);
        Debug.LogWarning("coroutine update");
        yield return new WaitForSeconds(time);
        Debug.LogWarning("coroutine einde");
    }
}
