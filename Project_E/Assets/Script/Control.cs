using System.Collections;
using UnityEngine;

public class Control : MonoBehaviour
{
    public int a;
    public int b;
    public string fruit;
    public string[] array = new string[5];
    public int[] scores = { 1, 2, 3, 4, 5 };
    public int[] score2 = { };
    public int[,] score3 = { { } , { } };
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        array[0] = "강대원";
        array[1] = "민영희";
        array[2] = "박두팔";
        array[3] = "안선생";
        array[4] = "함수빈";
        /*if(a > b)
        {
            Debug.Log("a가 b보다 더 큽니다.");
        }
        else if (a < b)
        {
            Debug.Log("b가 a보다 큽니다.");
        }
        else
        {
            Debug.Log("a와 b는 같습니다.");
        }
        switch(fruit)
        {
            case "apple":
            case "Apple":
                Debug.Log("사과야!");
                break;
            case "banana":
            case "Banana":
                Debug.Log("바나나야!");
                break;
                
            default:
                Debug.Log("모지...몰루겠네...");
                break;
        }
        for (int i = 0; i < 10; i++)
        {
            Debug.Log("i는 " + i + "야!");
        }
        int j = 0;
        while (j < 10)
        {
            Debug.Log("j는 " + j + "야!");
            ++j;
        }
        int k =  10;
        do
        {
            Debug.Log("k 의 값: " + k);
            k--;
        } while (k > 0);*/

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
