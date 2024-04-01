using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SipButton : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI sipText;
    [SerializeField] private Button sipButton;

    void Awake()
    {
        sipButton.onClick.AddListener(() => {
            GameManager.Instance.AddSips();
        });
    }
}
