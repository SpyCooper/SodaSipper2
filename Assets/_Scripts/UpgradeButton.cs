using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeButton : MonoBehaviour
{

    [SerializeField] private int whichButton;
    [SerializeField] private Button accessibleButton;

    private void Awake()
    {
        accessibleButton.onClick.AddListener(() => {
            GameManager.Instance.Upgrade(whichButton);
        });
    }
}
