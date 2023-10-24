using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HomeAdmin : MonoBehaviour
{
    public Image cleanButton;
    public Image waterButton;
    public Image weatherButton;

    public GameObject flagWater;
    public GameObject flagWeather;

    public Transform[] waterPoints;
    public Transform[] weatherPoints;

    public SpriteRenderer[] states;
    private bool isCleaning;
    private bool isWater;
    private bool isWeather;

    public bool[] statesCleaned;
    
    public bool isMap;
    public GameObject mapObj;
    public GameObject mapInfo;
    public Image mapImage;
    public Image usersImage;

    private GameObject objPermanent;
    private Information informationCode;

    public GameObject usersInfo;
    public GameObject u1;
    public GameObject u2;

    public TextMeshProUGUI points1;
    public TextMeshProUGUI points2;

    private int pts;

    void Awake()
    {
        objPermanent = GameObject.Find("ObjectPermanent");
        informationCode = objPermanent.GetComponent<Information>();
    }
    // Start is called before the first frame update
    void Start()
    {
        isCleaning = false;
        isWater = false;
        isWeather = false;
        isMap = true;
        points1.text = informationCode.users[0].points.ToString();
        points2.text = informationCode.users[1].points.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A)) 
        {
            if(isCleaning)
            {
                states[0].color = Color.white;
                statesCleaned[0] = true;
            }
            else if (isWater && statesCleaned[0])
            {
                Instantiate(flagWater, waterPoints[0]);
            }
            else if(isWeather && statesCleaned[0])
            {
                Instantiate(flagWeather, weatherPoints[0]);
            }
            cleanButton.color = Color.white;
            waterButton.color = Color.white;
            weatherButton.color = Color.white;
            isCleaning = false;
            isWater = false;
            isWeather = false;
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            if (isCleaning)
            {
                states[1].color = Color.white;
                statesCleaned[1] = true;
            }
            else if (isWater && statesCleaned[1])
            {
                Instantiate(flagWater, waterPoints[1]);
            }
            else if (isWeather && statesCleaned[1])
            {
                Instantiate(flagWeather, weatherPoints[1]);
            }
            cleanButton.color = Color.white;
            waterButton.color = Color.white;
            weatherButton.color = Color.white;
            isCleaning = false;
            isWater = false;
            isWeather = false;
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            if (isCleaning)
            {
                states[2].color = Color.white;
                statesCleaned[2] = true;
            }
            else if (isWater && statesCleaned[2])
            {
                Instantiate(flagWater, waterPoints[2]);
            }
            else if (isWeather && statesCleaned[2])
            {
                Instantiate(flagWeather, weatherPoints[2]);
            }
            cleanButton.color = Color.white;
            waterButton.color = Color.white;
            weatherButton.color = Color.white;
            isCleaning = false;
            isWater = false;
            isWeather = false;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            if (isCleaning)
            {
                states[3].color = Color.white;
                statesCleaned[3] = true;
            }
            else if (isWater && statesCleaned[3])
            {
                Instantiate(flagWater, waterPoints[3]);
            }
            else if (isWeather && statesCleaned[3])
            {
                Instantiate(flagWeather, weatherPoints[3]);
            }
            cleanButton.color = Color.white;
            waterButton.color = Color.white;
            weatherButton.color = Color.white;
            isCleaning = false;
            isWater = false;
            isWeather = false;
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            if (isCleaning)
            {
                states[4].color = Color.white;
                statesCleaned[4] = true;
            }
            else if (isWater && statesCleaned[4])
            {
                Instantiate(flagWater, waterPoints[4]);
            }
            else if (isWeather && statesCleaned[4])
            {
                Instantiate(flagWeather, weatherPoints[4]);
            }
            cleanButton.color = Color.white;
            waterButton.color = Color.white;
            weatherButton.color = Color.white;
            isCleaning = false;
            isWater = false;
            isWeather = false;
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            if (isCleaning)
            {
                states[5].color = Color.white;
                statesCleaned[5] = true;
            }
            else if (isWater && statesCleaned[5])
            {
                Instantiate(flagWater, waterPoints[5]);
            }
            else if (isWeather && statesCleaned[5])
            {
                Instantiate(flagWeather, weatherPoints[5]);
            }
            cleanButton.color = Color.white;
            waterButton.color = Color.white;
            weatherButton.color = Color.white;
            isCleaning = false;
            isWater = false;
            isWeather = false;
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            if (isCleaning)
            {
                states[6].color = Color.white;
                statesCleaned[6] = true;
            }
            else if (isWater && statesCleaned[6])
            {
                Instantiate(flagWater, waterPoints[6]);
            }
            else if (isWeather && statesCleaned[6])
            {
                Instantiate(flagWeather, weatherPoints[6]);
            }
            cleanButton.color = Color.white;
            waterButton.color = Color.white;
            weatherButton.color = Color.white;
            isCleaning = false;
            isWater = false;
            isWeather = false;
        }
    }

    public void SetActivity(int option)
    {
        if(option == 0)
        {
            cleanButton.color = Color.cyan;
            waterButton.color = Color.white;
            weatherButton.color = Color.white;
            isCleaning = true;
            isWater = false;
            isWeather = false;
        }
        else if(option == 1)
        {
            cleanButton.color = Color.white;
            waterButton.color = Color.cyan;
            weatherButton.color = Color.white;
            isWater = true;
            isCleaning = false;
            isWeather = false;
        }
        else
        {
            cleanButton.color = Color.white;
            waterButton.color = Color.white;
            weatherButton.color = Color.cyan;
            isWeather = true;
            isWater = false;
            isCleaning = false;
        }
    }

    public void ChangeScene(string scene)
    {
        informationCode.ChangeScene(scene);
    }

    public void ChangeInterface(bool change)
    {
        isMap = change;
        if(isMap)
        {
            usersInfo.SetActive(false);
            u1.SetActive(false);
            u2.SetActive(false);
            mapImage.color = Color.cyan;
            usersImage.color = Color.white;
            mapInfo.SetActive(true);
            mapObj.SetActive(true);
        }
        else
        {
            mapImage.color = Color.white;
            usersImage.color = Color.cyan;
            mapInfo.SetActive(false);
            mapObj.SetActive(false);
            usersInfo.SetActive(true);
            u1.SetActive(true); 
            u2.SetActive(true);
        }
    }

    public void SetPoints(string pts)
    {
        this.pts = int.Parse(pts);
    }

    public void AppendPoints(int id)
    {
        informationCode.SetPointsSpecificUser(id, pts);
        if (id == 0)
        {
            int ptsTemp = int.Parse(points1.text);
            points1.text = (ptsTemp + pts).ToString();
        }
        else
        {
            int ptsTemp = int.Parse(points2.text);
            points2.text = (ptsTemp + pts).ToString();
        }
    }

}
