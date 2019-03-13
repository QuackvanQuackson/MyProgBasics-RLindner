using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTests : MonoBehaviour
{

    string myName = "Quack";

    public void PrintDebug()
    {
        Debug.Log("Die Bananen (Musa), veraltet Paradiesfeigen, sind eine Pflanzengattung in der Familie der Bananengewächse (Musaceae) innerhalb der Einkeimblättrigen Pflanzen (Monokotyledonen). Die etwa 70 Arten stammen – bis auf eine Art in Tansania – alle aus dem tropischen bis subtropischen Asien und westlichen Pazifikraum.");
    }

    public void PrintMyName(string myNameis)
    {
        Debug.Log("Mein Name ist: " + myNameis);
    }

    public void AddNumbers(int first, int second)
    {
        Debug.Log("Add Numbers: first + second" + (first + second));
    }

    public void MultiplyNumbers(int first, int second, int third)
    {
        Debug.Log("Multiply Numbers: first * second * third = " + (first * second * third));
    }

    public void DivideNumbers(float first, float second, float third)
    {
        Debug.Log("Divide Numbers: first / second / third = " + first / second / third);
    }

    public void ConcatinateStrings(string myName, string msg)
    {
        Debug.Log("First concatination " + myName + " , " + msg);
    }

    // Use this for initialization
    void Start()
    {
        PrintDebug();
        PrintMyName("boi");
        PrintMyName(myName);
        AddNumbers(1, 2);
        MultiplyNumbers(22, 400, 39);
        DivideNumbers(20.0f, 2.0f, 45.0f);
        ConcatinateStrings("Quack", "em llik");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
