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

    public void Button1ShowerClicked()
    {
        ShowerButton.color = Color.grey;
        BathButton.color = Color.white;

        ShowerSelected = true;
        BathSelected = false;
    }

    public void Button2BathClicked()
    {
        ShowerButton.color = Color.white;
        BathButton.color = Color.grey;

        ShowerSelected = false;
        BathSelected = true;
    }

    public void PlusButtonPressed()
    {
        if (litre < 10)
        {
            litre = litre + 2;
            Litres.text = litre.ToString() + " litres";
        }
    }

    public void MinusButtonPressed()
    {
        if(litre > 0)
        {
            litre = litre - 2;
            Litres.text = litre.ToString() + " litres";
        }
    }

    public void EnterButton1()
    {
        if(litre == 6)
        {
            Score = Score + 1;
            Score1.text = Score.ToString();
            Score2.text = Score.ToString();
        }

        Question1.SetActive(false);
        Question2.SetActive(true);
    }

    public void EnterButton2()
    {
        if(BathSelected)
        {
            Score = Score + 1;
            Score1.text = Score.ToString();
            Score2.text = Score.ToString();
        }

        Question2.SetActive(false);
        Final.SetActive(true);
    }
}
