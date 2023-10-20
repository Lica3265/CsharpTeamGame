using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Cannon;
    public GameObject Head;
    public float speed = 50f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        float v = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;

        if (Head.transform.rotation.z > -0.5 && v > 0)
        {
            Head.transform.Rotate(new Vector3(0, 0, v));
        }
        if (Head.transform.rotation.z < 0 && v < 0)
        {
            Head.transform.Rotate(new Vector3(0, 0, v));
        }
        // Debug.Log(h + "," + Cannon.transform.rotation.y);


        if (Cannon.transform.rotation.y > 0.3 && h < 0)
        {
            Cannon.transform.Rotate(new Vector3(0, h, 0));
        }
        if (Cannon.transform.rotation.y < 0.99 && h > 0)
        {
            Cannon.transform.Rotate(new Vector3(0, h, 0));
        }
    }


}
