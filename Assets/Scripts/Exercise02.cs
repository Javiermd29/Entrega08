using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using TMPro;

public class Exercise02 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI bottlesText1;
    [SerializeField] private TextMeshProUGUI bottlesText2;
    [SerializeField] private TextMeshProUGUI bottlesText3;
    [SerializeField] private TextMeshProUGUI bottlesText4;
    [SerializeField] private TextMeshProUGUI bottlesText5;
    [SerializeField] private TextMeshProUGUI bottlesText6;
    [SerializeField] private TextMeshProUGUI bottlesText7;
    [SerializeField] private TextMeshProUGUI bottlesText8;

    void Start()
    {
        StartCoroutine(Exercise2());
    }

    void Update()
    {

    }

    private IEnumerator Exercise2()
    {

        for (int a = 10; a >= 0; a--)
        {
            bottlesText1.SetText(a + " green bottles");
            yield return new WaitForSeconds(0.5f);

            for (int b = 10; b >= 0; b--)
            {
                bottlesText2.SetText("Hanging on the wall");
                yield return new WaitForSeconds(0.5f);

                for (int c = 10; b >= 0; c--)
                {
                    bottlesText3.SetText(c + " green bottles");
                    yield return new WaitForSeconds(0.5f);

                    for (int d = 10; d >= 0; d--)
                    {
                        bottlesText4.SetText("Hanging on the wall");
                        yield return new WaitForSeconds(0.5f);

                        for (int e = 10; e >= 0; e--) {

                            bottlesText5.SetText("And if one green bottle");
                            yield return new WaitForSeconds(0.5f);

                            for(int f = 10; f >= 0; f--)
                            {

                                bottlesText6.SetText("Should accidentally fall");
                                yield return new WaitForSeconds(0.5f);

                                for (int g = 10; f >= 0; g--){

                                    bottlesText7.SetText("There'll be " + (g-1) + " green bottles");
                                    yield return new WaitForSeconds(0.5f);

                                    for(int h = 10; h >= 0; h--){

                                        bottlesText8.SetText("Hanging of the wall");
                                        yield return new WaitForSeconds(0.5f);

                                    }

                                }

                            }
                        }
                    }
                }
            }
        }
    }
}
