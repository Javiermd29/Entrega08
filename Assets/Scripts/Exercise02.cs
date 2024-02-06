using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using TMPro;

public class Exercise02 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI bottlesText;

    void Start()
    {
        StartCoroutine(Exercise2());
    }

    void Update()
    {

    }

    private IEnumerator Exercise2()
    {
        int sum = 0;

        for (int i = 1; i <= 10; i++)
        {
            bottlesText.SetText(sum + " + " + i + " = " + sum);
            sum += i;
            yield return new WaitForSeconds(0.5f);
        }


    }
}
