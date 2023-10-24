using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TriviaScript : MonoBehaviour
{
    //Panel Principal
    public GameObject panel;
    private bool isGaming;
    private bool end;
    private int questionCount;
    //Trivia
    public GameObject error;
    public GameObject correct;
    private float resultCount;
    private bool isWaiting;
    //Questions and buttons
    public GameObject panelQuestions;
    public GameObject question1;
    public GameObject question2;
    public GameObject question3;
    public GameObject buttonTrue1;
    public GameObject buttonFalse1;
    public GameObject buttonTrue2;
    public GameObject buttonFalse2;
    public GameObject buttonTrue3;
    public GameObject buttonFalse3;
    //Puntaje
    private int points;
    public TextMeshProUGUI pointsText;
    public GameObject PointsInfo;
    //Characters
    public GameObject elmo;
    public GameObject monster;
    public GameObject oscar;

    private GameObject objPermanent;
    private Information informationCode;

    void Awake()
    {
        objPermanent = GameObject.Find("ObjectPermanent");
        informationCode = objPermanent.GetComponent<Information>();
    }

    // Start is called before the first frame update
    void Start()
    {
        isWaiting = false;
        resultCount = 0;
        isGaming = false;
        end = false;
        questionCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        pointsText.text = points.ToString();
        if (isGaming)
        {
            panelQuestions.SetActive(true);
            if(questionCount == 0)
            {
                question1.SetActive(true);
                buttonTrue1.SetActive(true);
                buttonFalse1.SetActive(true);
                monster.SetActive(true);
            }
            else if(questionCount == 1)
            {
                if(!isWaiting)
                {
                    question1.SetActive(false);
                    buttonTrue1.SetActive(false);
                    buttonFalse1.SetActive(false);
                    question2.SetActive(true);
                    buttonTrue2.SetActive(true);
                    buttonFalse2.SetActive(true);
                    monster.SetActive(false);
                    elmo.SetActive(true);
                }
            }
            else
            {
                if (!isWaiting)
                {
                    question2.SetActive(false);
                    buttonTrue2.SetActive(false);
                    buttonFalse2.SetActive(false);
                    question3.SetActive(true);
                    buttonTrue3.SetActive(true);
                    buttonFalse3.SetActive(true);
                    elmo.SetActive(false);
                    oscar.SetActive(true);
                    end = true;
                    isGaming = false;
                }
            }
        }
        if(isWaiting)
        {
            resultCount -= Time.deltaTime;
            if(resultCount <= 0.0f)
            {
                error.SetActive(false);
                correct.SetActive(false);
                isWaiting = false;
                if (end)
                {
                    this.ExitTrivia("Home");
                }
            }
        }
    }

    public void SetAnswer(int num)
    {
        if(num == 0)
        {
            error.SetActive(true);
        }
        else
        {
            points += 10;
            correct.SetActive(true);
        }
        resultCount = 2f;
        isWaiting = true;
        questionCount++;
    }

    public void StartTrivia()
    {
        PointsInfo.SetActive(true);
        panel.SetActive(false);
        isGaming = true;
        questionCount = 0;

    }

    public void ExitTrivia(string scene)
    {
        informationCode.SetCurrentUserPoint(points);
        SceneManager.LoadScene(scene);
    }
}
