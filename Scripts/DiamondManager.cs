using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DiamondManager : MonoBehaviour
{
    private static TextMeshProUGUI diamondsText;
    private static int diamondscore;

    private void Start()
    {
        diamondscore = 0;
        diamondsText = GetComponent<TextMeshProUGUI>();
    }

    public static int DiamondScore
    {
        get
        {
            return diamondscore;
        }
        set
        {
            diamondscore = value;
            diamondsText.text = diamondscore.ToString();
        }
    }

    private void OnDestroy()
    {
        diamondscore=0;
    }
}
