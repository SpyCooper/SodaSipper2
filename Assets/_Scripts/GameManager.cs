using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private int sips;
    [SerializeField] private TextMeshProUGUI sipCounterText;

    [SerializeField] private GameObject upgrade1Accessable;
    [SerializeField] private GameObject upgrade1Inaccessable;
    bool upgrade1 = false;
    [SerializeField] private GameObject upgrade2Accessable;
    [SerializeField] private GameObject upgrade2Inaccessable;
    bool upgrade2 = false;
    [SerializeField] private GameObject upgrade3Accessable;
    [SerializeField] private GameObject upgrade3Inaccessable;
    bool upgrade3 = false;
    [SerializeField] private GameObject upgrade4Accessable;
    [SerializeField] private GameObject upgrade4Inaccessable;
    bool upgrade4 = false;
    [SerializeField] private GameObject upgrade5Accessable;
    [SerializeField] private GameObject upgrade5Inaccessable;
    bool upgrade5 = false;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        sips = 0;
        UpdateCounter();
        upgrade1Inaccessable.SetActive(false);
        upgrade2Inaccessable.SetActive(false);
        upgrade3Inaccessable.SetActive(false);
        upgrade4Inaccessable.SetActive(false);
        upgrade5Inaccessable.SetActive(false);
    }

    public void AddSips()
    {
        int multiplier = 1;
        if(upgrade1)
        {
            multiplier = 2;
        }
        if (upgrade2)
        {
            multiplier = 5;
        }
        if (upgrade3)
        {
            multiplier = 10;
        }
        if (upgrade4)
        {
            multiplier = 50;
        }
        if (upgrade5)
        {
            multiplier = 100;
        }

        sips += 1 * multiplier;

        UpdateCounter();
    }

    private void UpdateCounter()
    {
        string sipstext = sips.ToString();
        sipCounterText.text = "Number of Sips: " + sipstext;
    }

    public void Upgrade(int whichUpgrade)
    {
        switch (whichUpgrade)
        {
            case 1:
                if(sips >= 100)
                {
                    sips -= 100;
                    upgrade1 = true;
                    upgrade1Accessable.SetActive(false);
                    upgrade1Inaccessable.SetActive(true);
                }
                break;
            case 2:
                if (sips >= 500)
                {
                    sips -= 500;
                    upgrade2 = true;
                    upgrade2Accessable.SetActive(false);
                    upgrade2Inaccessable.SetActive(true);
                }
                break;
            case 3:

                if (sips >= 1500)
                {
                    sips -= 1500;
                    upgrade3 = true;
                    upgrade3Accessable.SetActive(false);
                    upgrade3Inaccessable.SetActive(true);
                }
                break;
            case 4:
                if (sips >= 10000)
                {
                    sips -= 10000;
                    upgrade4 = true;
                    upgrade4Accessable.SetActive(false);
                    upgrade4Inaccessable.SetActive(true);
                }
                break;
            case 5:
                if (sips >= 1000000)
                {
                    sips -= 1000000;
                    upgrade5 = true;
                    upgrade5Accessable.SetActive(false);
                    upgrade5Inaccessable.SetActive(true);
                }
                break;
            default:
                break;
        }
        UpdateCounter();
    }

    public void AddSetAmt(int amt)
    {
        sips += amt;

        UpdateCounter();
    }
}
