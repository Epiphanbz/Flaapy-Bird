using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipeline : MonoBehaviour
{
    public float speed;
    public float top;
    public float bottom;
    void Start()
    {
        float y = Random.Range(-bottom,top);
        this.transform.localPosition += new Vector3(0, y, 0);

        Destroy(this.gameObject, 2f);
    }

    void Update()
    {
        this.transform.position += new Vector3(-speed, 0) * Time.deltaTime;
    }
}
