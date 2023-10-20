using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameWin : MonoBehaviour
{
    // Start is called before the first frame update
    public int T;
    public Text win;
    void Start()
    {
        T = 7;
    }

    // Update is called once per frame
    void Update()
    {
        if (T == 0)
        {
            win.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
    void m1()
    {
        T--;
    }
}
