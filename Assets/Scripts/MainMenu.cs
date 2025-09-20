using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Used on the Main Menu

    public void StartMinigame1() //CONTROL WATER SUPPLY
    {
        SceneManager.LoadScene("MiniGame1");
    }

    public void StartMinigame2()//QUIZ
    {
        SceneManager.LoadScene("MiniGame2");
    }
}
