using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoxd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)) 
        {
            this.gameObject.transform.position += Vector3.right;
        }

        if (Input.GetKey(KeyCode.A))
        {
            this.gameObject.transform.position -= Vector3.right;
        }
    }
}
