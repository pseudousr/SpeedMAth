using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MathProblem2 : MonoBehaviour
{

    public Text firstNumber;
    public Text secondNumber;
    public Text answer1;
    public Text answer2;

    public List<int> easyMathList = new List<int>();

    public int randomFirstNumber;
    public int randomSecondNumber;

    int firstNumberInProblem;
    int secondNumberInProblem;
    int answerOne;
    int answerTwo;
    int displayRandomAnswer;
    int randomAnswerPlacement;

    public int currentAnswer;
    public Text rightOrWrong_Text;

    public void Start()
    {
        DisplayMathProblem();
    }

    public void DisplayMathProblem()
    {
        randomFirstNumber = Random.Range(0, easyMathList.Count + 1);
        randomSecondNumber = Random.Range(0, easyMathList.Count + 1);

        firstNumberInProblem = randomFirstNumber;
        secondNumberInProblem = randomSecondNumber;

        answerOne = firstNumberInProblem - secondNumberInProblem;
        displayRandomAnswer = Random.Range(0, 2);
        if (displayRandomAnswer == 0)
        {
            answerTwo = answerOne + Random.Range(1, 5);
        }
        else
        {
            answerTwo = answerOne - Random.Range(1, 5);
        }

        firstNumber.text = " " + firstNumberInProblem;
        secondNumber.text = " " + secondNumberInProblem;

        randomAnswerPlacement = Random.Range(0, 2);
        if (randomAnswerPlacement == 0)
        {
            answer1.text = " " + answerOne;
            answer2.text = " " + answerTwo;
            currentAnswer = 0;
        }
        else
        {
            answer1.text = " " + answerTwo;
            answer2.text = " " + answerOne;
            currentAnswer = 1;
        }
    }
    public void ButtonAnswer1()
    {

        if (currentAnswer == 0)
        {
            rightOrWrong_Text.enabled = true;
            rightOrWrong_Text.color = Color.green;
            rightOrWrong_Text.text = ("Correct!");
            Invoke("TurnOffText", 1);
        }
        else
        {
            rightOrWrong_Text.enabled = true;
            rightOrWrong_Text.color = Color.red;
            rightOrWrong_Text.text = ("Wrong, Try Again!");
            Invoke("TurnOffText", 1);
        }

    }
    public void ButtonAnswer2()
    {
        if (currentAnswer == 1)
        {
            rightOrWrong_Text.enabled = true;
            rightOrWrong_Text.color = Color.green;
            rightOrWrong_Text.text = ("Correct!");
            Invoke("TurnOffText", 1);
        }
        else
        {
            rightOrWrong_Text.enabled = true;
            rightOrWrong_Text.color = Color.red;
            rightOrWrong_Text.text = ("Wrong, Try Again!");
            Invoke("TurnOffText", 1);
        }
    }
    public void TurnOffText()
    {
        if (rightOrWrong_Text != null)
            rightOrWrong_Text.enabled = false;
        DisplayMathProblem();
    }
}
