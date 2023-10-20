using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMove : MonoBehaviour
{
    private float Speed = 2f;
    public Transform EndP;
    public Transform StartP;

    public bool OnMove;
    private Vector3 Sp;
    private Vector3 Ep;
    // Start is called before the first frame update
    void Start()
    {
        Sp = StartP.position;
        Ep = EndP.position;
    }

    // Update is called once per frame
    void Update()
    {
        float step = Speed * Time.deltaTime;
        if (OnMove == false)
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, Ep, step);
        }
        else
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, Sp, step);
        }
        // Debug.Log(this.transform.position.z + "," + Ep.z);
        if (this.transform.position.z == Ep.z && OnMove == false)
        {
            OnMove = true;
        }
        else if (this.transform.position.z == Sp.z && OnMove == true)
        {
            OnMove = false;
        }
    }
}
