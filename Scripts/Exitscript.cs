using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Exitscript : MonoBehaviour
{

    
    public Button startText;
    public Button exitText;
    public Button optionText;
    public Button creditText;

    
    public Canvas quitMenu;
    public Canvas introductionMenu;
    public Canvas credit;
    public Canvas option;

   

    // Use this for initialization
    void Start()
    {
        quitMenu = quitMenu.GetComponent<Canvas>();
        startText = startText.GetComponent<Button>();
        exitText = exitText.GetComponent<Button>();
        optionText = optionText.GetComponent<Button>();
        creditText = creditText.GetComponent<Button>();

        
       credit = credit.GetComponent<Canvas>();
        option = option.GetComponent<Canvas>();
        introductionMenu = introductionMenu.GetComponent<Canvas>();

        
        quitMenu.enabled = false;
        introductionMenu.enabled = false;
        credit.enabled = false;
        option.enabled = false;
    }

    public void ExitPress()
    {
        quitMenu.enabled = true;
        startText.enabled = false;
        exitText.enabled = false;
        introductionMenu.enabled = false;
        credit.enabled = false;
        option.enabled = false;
        
    }
    public void NoPress()

    {
        SceneManager.LoadScene("mainmenu", LoadSceneMode.Single);
        
      
    }
    public void openIntroduction()
    {
        quitMenu.enabled = false;
        startText.enabled = true;
        exitText.enabled = true;
        optionText.enabled = true;
        creditText.enabled = true;
        introductionMenu.enabled = true;
        credit.enabled = false;
        option.enabled = false;

    }

    public void openCredit ()
    {
        quitMenu.enabled = false;
        startText.enabled = true;
        exitText.enabled = true;
        optionText.enabled = true;
        creditText.enabled = true;
        introductionMenu.enabled = false;
        credit.enabled = true;
        option.enabled = false;
    }

    public void openOption ()
    {
        quitMenu.enabled = false;
        startText.enabled = true;
        exitText.enabled = true;
        optionText.enabled = true;
        creditText.enabled = true;
        introductionMenu.enabled = false;
        credit.enabled = false;
        option.enabled = true;


    }
   




    public void StartLevel()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void ExitGame()
    {
        Application.Quit();

    }

    // Update is called once per frame
    void Update()
    {
      

        


         
    }
}
