using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BulletSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject BulletPrefab;
    float time = 0f;
    public float destroyTime = 10f;
    // Use this for initialization

    public int BC;
    public int CurBC;
    public Text B;

    public Button res;
    void Start()
    {
        BC = 20;
        CurBC = BC;
        B.text = "Bullet :" + CurBC.ToString();
        res.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {

        if (CurBC > 0)
        {
            shoot();
        }
        if (CurBC <= 0)
        {
            res.gameObject.SetActive(true);
        }

    }
    void shoot()
    {
        time += Time.deltaTime;
        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (time > 0.5f)
            {
                Instantiate(BulletPrefab, this.transform.position, this.transform.rotation);
                time = 0;
            }
            CurBC--;
            B.text = "Bullet  :" + CurBC.ToString();
        }
    }
    void TaskOnClick()
    {
        SceneManager.LoadScene("Game");
    }
}
