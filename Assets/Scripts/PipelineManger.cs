using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipelineManger : MonoBehaviour
{
    public GameObject template;
    void Start()
    {
        
    }


    void Update()
    {
        
    }

    Coroutine coroutine = null;
    
    public void StartRun()
    {
        coroutine = StartCoroutine(GeneratePiplines());
    }

    public void Stop()
    {
        StopCoroutine(coroutine);
    }

    IEnumerator GeneratePiplines()
    {
        while(true)
        {
            GeneratePipline();

            yield return new WaitForSeconds(2f);
        }
    }

    void GeneratePipline()
    {
        Instantiate(template, this.transform);
    }
}


