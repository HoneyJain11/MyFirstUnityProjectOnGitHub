using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class JumpToScene : MonoBehaviour
{
    // Start is called before the first frame update
    //public void buttonclick();
    public Button Button_1,Button_2,Button_3;
    
     public string newScene_1,newScene_2,newScene_3;
    void Start()
    {
    
      Button_1.onClick.AddListener(ButtonClick1);
      Button_2.onClick.AddListener(ButtonClick2);
      Button_3.onClick.AddListener(ButtonClick3);
      //buttonclick();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ButtonClick1(){
        Debug.Log("hello button pressed");
        SceneManager.LoadScene(newScene_1);
    }
    void ButtonClick2(){
        Debug.Log("hello button pressed");
        SceneManager.LoadScene(newScene_2);
    }

   void ButtonClick3(){
        Debug.Log("hello button pressed");
        SceneManager.LoadScene(newScene_3);
    }

}
