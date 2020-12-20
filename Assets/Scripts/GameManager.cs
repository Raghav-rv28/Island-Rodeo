using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{ 
    private CharacterController2D cc= new CharacterController2D();
    public TextMeshProUGUI Cointext;
	public TextMeshProUGUI Timetext;
    // Start is called before the first frame update
    void Start()
    {
        Cointext.text="Total Score:"+ cc.getScore();
        Timetext.text="Total Time Taken:"+Mathf.RoundToInt(cc.getTime()).ToString();
    }

    public void triggerMenuBehaviour(int i) {
        switch(i){
            default:
            case(0):
            SceneManager.LoadScene("Level1");
            break;
            case(1):
            Application.Quit();
            break;
        }
    }
}
