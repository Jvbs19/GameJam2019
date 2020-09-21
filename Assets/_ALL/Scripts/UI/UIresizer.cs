using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIresizer : MonoBehaviour
{
    // Use this for initialization
    private void Awake()
    {
        float num1 = Screen.height;
        float num2 = Screen.width;
        float ratio = num1 / num2;

        if (ratio <= 1.5f)
        {
            gameObject.GetComponent<CanvasScaler>().referenceResolution = new Vector2(1130, 600);
        }
    }
}
