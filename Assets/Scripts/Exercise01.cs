using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using TMPro;

public class Exercise01 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI sumText;

    void Start()
    {
        StartCoroutine(Exercise1());
    }

    void Update()
    {
        
    }

    private IEnumerator Exercise1()
    {
        int sum = 0;

        for (int i = 1; i <= 10; i++)
        {
            sumText.SetText(sum + " + " + i  + " = " + sum);
            sum += i;
            yield return new WaitForSeconds(1f);
        }

        sumText.SetText("The sum of numbers from 1 to 10 is: " + sum);
        

    }
}
