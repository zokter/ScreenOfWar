using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textMeshProUGUI;

    private void Awake()
    {
        //textMeshProUGUI.text = "Some shit";
    }

    public void SetText(string text)
    {
        textMeshProUGUI.text = text;
    }
}
