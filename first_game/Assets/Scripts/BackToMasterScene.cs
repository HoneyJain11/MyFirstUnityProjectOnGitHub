using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class BackToMasterScene : MonoBehaviour
{
    public Button backButton;
    //void BackButtonClick();
   
    void BackButtonClick()
    {
        Debug.Log("Back Button Pressed");
         SceneManager.LoadScene ("MasterScene");
    }

    // Start is called before the first frame update

    void Start()
    {
        backButton.onClick.AddListener(BackButtonClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
