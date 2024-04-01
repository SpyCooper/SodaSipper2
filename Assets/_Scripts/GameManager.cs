using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private int sips;
    [SerializeField] private TextMeshProUGUI sipCounterText;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        sips = 0;
        UpdateCounter();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddSips()
    {
        sips++;

        UpdateCounter();
    }

    private void UpdateCounter()
    {
        string sipstext = sips.ToString();
        sipCounterText.text = "Number of Sips: " + sipstext;
    }
}
