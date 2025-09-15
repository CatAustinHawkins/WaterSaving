using System.Collections;
using UnityEngine;
using TMPro;
public class WaterSupply : MonoBehaviour
{

    public int WaterTankValue;
    public int ResevoirValue;

    public GameObject WaterTank;

    public Vector3 WTSize;
    public float shrink1;

    public GameObject Resevoir;

    public GameObject Button; 

    public Vector3 RSize;
    public float shrink2;

    //HOUSE
    public SpriteRenderer Window1;
    public SpriteRenderer Window2;
    public SpriteRenderer Window3;
    public SpriteRenderer Window4;

    public bool Window1Deactivate;
    public bool Window2Deactivate;
    public bool Window3Deactivate;
    public bool Window4Deactivate;

    public int random;

    public int Timer;
    public TextMeshProUGUI CountDownText;
    public bool GameOverTime;

    public TextMeshProUGUI ScoreText;

    public GameObject GameOVER;

    public int rotatevalue = 15;

    void Start()
    {
        StartCoroutine(ResevoirDelay());
        RandomWindow();
        StartCoroutine(Countdown());
    }

    private void Update()
    {
        WTSize = WaterTank.transform.localScale;
        RSize = Resevoir.transform.localScale;

        if (WTSize.y < -0 || RSize.y < 0)
        {
            GameOVER.SetActive(true);
            GameOverTime = true;
            ScoreText.text = Timer.ToString();
        }
    }

    public void RandomWindow()
    {
        Window1Deactivate = false;
        Window2Deactivate = false;
        Window3Deactivate = false;
        Window4Deactivate = false;
        random = Random.Range(0, 4);
        switch (random)
        {
            case 1:
                Window1Activate();
                break;
            case 2:
                Window2Activate();
                break;
            case 3:
                Window3Activate();
                break;
            case 4:
                Window4Activate();
                break;
            default:
                Window1Activate();
                break;
        }
        StartCoroutine(ChooseWindow());
    }

    public void Window1Activate()
    {
        if (Window1Deactivate == false)
        {
            Window1.color = Color.yellow;

            WaterTankDrain1();
            StartCoroutine(Window1Delay());
        }
    }
    public void Window2Activate()
    {
        if (Window2Deactivate == false)
        {
            Window2.color = Color.yellow;

            WaterTankDrain2();
            StartCoroutine(Window2Delay());
        }
    }
    public void Window3Activate()
    {
        if (Window3Deactivate == false)
        {
            Window3.color = Color.yellow;

            WaterTankDrain3();
            StartCoroutine(Window3Delay());
        }
    }
    public void Window4Activate()
    {
        if (Window4Deactivate == false)
        {
            Window4.color = Color.yellow;

            WaterTankDrain4();
            StartCoroutine(Window4Delay());
        }
    }

    public void WaterTankDrain1()
    {
        WTSize = WaterTank.transform.localScale;
        shrink1 = WTSize.y;

        if (WTSize.y > 0)
        {
            WTSize.y = shrink1 - 0.18f;
            WaterTank.transform.localScale = WTSize;
        }

        StartCoroutine(WaterTankDelay1());
    }
    public void WaterTankDrain2()
    {
        WTSize = WaterTank.transform.localScale;
        shrink1 = WTSize.y;

        if (WTSize.y > 0)
        {
            WTSize.y = shrink1 - 0.32f;
            WaterTank.transform.localScale = WTSize;
        }

        StartCoroutine(WaterTankDelay2());
    }
    public void WaterTankDrain3()
    {
        WTSize = WaterTank.transform.localScale;
        shrink1 = WTSize.y;

        if (WTSize.y > 0)
        {
            WTSize.y = shrink1 - 0.25f;
            WaterTank.transform.localScale = WTSize;
        }

        StartCoroutine(WaterTankDelay3());
    }
    public void WaterTankDrain4()
    {
        WTSize = WaterTank.transform.localScale;
        shrink1 = WTSize.y;

        if (WTSize.y > 0)
        {
            WTSize.y = shrink1 - 0.35f;
            WaterTank.transform.localScale = WTSize;
        }

        StartCoroutine(WaterTankDelay4());
    }
    public void WaterResevoirPressed()
    {
        RSize = Resevoir.transform.localScale;
        shrink2 = RSize.y;

        if (RSize.y > -1f)
        {
            RSize.y = shrink2 - 0.35f;
            Resevoir.transform.localScale = RSize;
        }

        WTSize = WaterTank.transform.localScale;
        shrink1 = WTSize.y;

        if (WTSize.y < 7.3)
        {
            WTSize.y = shrink1 + 0.2f;
            WaterTank.transform.localScale = WTSize;
        }

        rotatevalue = rotatevalue + 15;

        Button.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, rotatevalue);
    }

    public void WaterResevoirIncrease()
    {
        RSize = Resevoir.transform.localScale;
        shrink2 = RSize.y;

        if (RSize.y < 3.5)
        {
            RSize.y = shrink2 + 0.07f;
            Resevoir.transform.localScale = RSize;
            
        }

        StartCoroutine(ResevoirDelay());

    }

    IEnumerator ResevoirDelay()
    {
        yield return new WaitForSeconds(1);
        WaterResevoirIncrease();
    }

    IEnumerator WaterTankDelay1()
    {
        yield return new WaitForSeconds(1);
        if (Window1Deactivate == false)
        {
            WaterTankDrain1();
        }
    }

    IEnumerator WaterTankDelay2()
    {
        yield return new WaitForSeconds(1);
        if (Window2Deactivate == false)
        {
            WaterTankDrain2();
        }
    }

    IEnumerator WaterTankDelay3()
    {
        yield return new WaitForSeconds(1);
        if (Window3Deactivate == false)
        {
            WaterTankDrain3();
        }
    }

    IEnumerator WaterTankDelay4()
    {
        yield return new WaitForSeconds(1);
        if (Window4Deactivate == false)
        {
            WaterTankDrain4();
        }
    }

    IEnumerator Window1Delay()
    {
        yield return new WaitForSeconds(5);
        Window1Deactivate = true;
        Window1.color = Color.grey;
    }
    IEnumerator Window2Delay()
    {
        yield return new WaitForSeconds(5);
        Window2Deactivate = true;
        Window2.color = Color.grey;
    }
    IEnumerator Window3Delay()
    {
        yield return new WaitForSeconds(5);
        Window3Deactivate = true;
        Window3.color = Color.grey;
    }
    IEnumerator Window4Delay()
    {
        yield return new WaitForSeconds(5);
        Window4Deactivate = true;
        Window4.color = Color.grey;
    }

    IEnumerator ChooseWindow()
    {
        yield return new WaitForSeconds(Random.Range(6, 10));
        RandomWindow();
    }

    IEnumerator Countdown()
    {
        if(GameOverTime == false)
        {
            yield return new WaitForSeconds(1f);
            Timer = Timer + 1;
            CountDownText.text = Timer.ToString();
            StartCoroutine(Countdown());
        }
    }
}