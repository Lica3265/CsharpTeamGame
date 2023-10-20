using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 0.1f;
    public GameWin win;
    // Use this for initialization
    void Start()
    {
        Destroy(this.gameObject, 10.0f);
        win = GameObject.FindGameObjectWithTag("WIn").GetComponent<GameWin>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(new Vector3(0, -speed, 0));
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Target")
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
            win.T--;
        }
    }

}
