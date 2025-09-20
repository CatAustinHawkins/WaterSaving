using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    //Used on the Water Quiz and Water Supply Management modes to take player back to Main Menu

    public void BackButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
