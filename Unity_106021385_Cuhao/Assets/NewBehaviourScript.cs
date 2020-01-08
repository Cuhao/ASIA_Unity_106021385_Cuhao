using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("寶箱數量介面")]
    public Text textCount;
    [Header("提示畫面")]
    public GameObject objTop;
    public int propCount;
    public int propTotal = 10;
    private void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject);
        if(collision.gameObject.tag == "寶箱")
        {
            Destroy(collision.gameObject);
            propCount ++;
            textCount.text = "寶箱" + propCount + "/ 10";
        }
    }
    private void Update()
    {
        GameOver();
    }
    private void GameOver()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            //Application.LoadLevel("遊戲場景");舊版API
            SceneManager.LoadScene("遊戲場景");
        }
    }
}
