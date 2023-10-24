using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class HomeScript : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI energyText;
    public TextMeshProUGUI pointsText;

    public SpriteRenderer hairM;
    public GameObject hairMObject;
    public SpriteRenderer hairF;
    public GameObject hairFObject;
    public SpriteRenderer skin;
    public SpriteRenderer tshirt;

    private GameObject objPermanent;
    private Information informationCode;

    public string[] dialogues;
    public TextMeshProUGUI dialogue;
    public GameObject[] arrows;
    private int indice;
    private int currentArrow;
    private float changeDialogueCount;

    void Awake()
    {
        objPermanent = GameObject.Find("ObjectPermanent");
        informationCode = objPermanent.GetComponent<Information>();
        if (informationCode.currentUser.isMale)
        {
            hairFObject.SetActive(false);
            hairMObject.SetActive(true);
        }
        else
        {
            hairMObject.SetActive(false);
            hairFObject.SetActive(true);
        }
    }

    private void Start()
    {
        hairM.color = informationCode.currentUser.hairColor;
        hairF.color = informationCode.currentUser.hairColor;
        skin.color = informationCode.currentUser.skinColor;
        tshirt.color = informationCode.currentUser.tshirtColor;
        nameText.text = informationCode.currentUser.name;
        energyText.text = informationCode.currentUser.energy.ToString();
        pointsText.text = informationCode.currentUser.points.ToString();
        changeDialogueCount = 0;
        currentArrow = 0;
    }

    // Update is called once per frame
    void Update()
    {
        changeDialogueCount -= Time.deltaTime;
        if (changeDialogueCount <= 0)
        {
            arrows[currentArrow].gameObject.SetActive(false);
            changeDialogueCount = 5;
            indice = Random.Range(0, dialogues.Length);
            currentArrow = indice;
            arrows[indice].gameObject.SetActive(true);
            dialogue.text = dialogues[indice];
        }
    }

    public void Exit()
    {
        informationCode.ResetCurrentUser();
    }

    public void ChangeScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
