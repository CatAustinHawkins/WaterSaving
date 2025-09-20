using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WaterQuiz : MonoBehaviour
{

    public GameObject Question1;
    public GameObject Question2;
    public GameObject Final;

    public Image ShowerButton;
    public Image BathButton;

    public bool ShowerSelected;
    public bool BathSelected;

    public TextMeshProUGUI Score1;
    public TextMeshProUGUI Score2;

    public int Score;

    public TextMeshProUGUI Litres;
    public int litre;

    //If the player clicks the Shower option, unselect the Bath
    public void Button1ShowerClicked()
    {
        ShowerButton.color = Color.grey;
        BathButton.color = Color.white;

        ShowerSelected = true;
        BathSelected = false;
    }

    //If the player clicks the Bath option, unselect the Shower
    public void Button2BathClicked()
    {
        ShowerButton.color = Color.white;
        BathButton.color = Color.grey;

        ShowerSelected = false;
        BathSelected = true;
    }

    //Add 2 Litres
    public void PlusButtonPressed()
    {
        if (litre < 10)//Capped at 10 to prevent players from choosing two high, helps guide player to what the answer might be 
        {
            litre = litre + 2;
            Litres.text = litre.ToString() + " litres";
        }
    }

    //Minus 2 Litres
    public void MinusButtonPressed()
    {
        if(litre > 0)//Capped at 0 
        {
            litre = litre - 2;
            Litres.text = litre.ToString() + " litres";
        }
    }

    //When player submits the answer for question 1
    public void EnterButton1()
    {
        if(litre == 6)//correct answer was 6 litres
        {
            Score = Score + 1;
            Score1.text = Score.ToString();
            Score2.text = Score.ToString();
        }

        Question1.SetActive(false); //Hide Q1
        Question2.SetActive(true); //Open Q2
    }

    //When player submits the answer for question 2
    public void EnterButton2()
    {
        if(BathSelected)//Correct answer was bath
        {
            Score = Score + 1;
            Score1.text = Score.ToString();
            Score2.text = Score.ToString();
        }

        Question2.SetActive(false);//Hide Q1
        Final.SetActive(true);//Show win screen
    }
}
