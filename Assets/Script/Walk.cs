using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{
    private float playerSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            this.gameObject.transform.Translate(Vector2.left * playerSpeed * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.D))
        {
            this.gameObject.transform.Translate(Vector2.right * playerSpeed * Time.deltaTime);
        }
    }
}
