using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AvatarUser : MonoBehaviour
{
    public SpriteRenderer hairM;
    public SpriteRenderer hairF;
    public SpriteRenderer skin;
    public SpriteRenderer tshirt;
    public SpriteRenderer pants;

    public Button maleB;
    public Button femaleB;
    public GameObject hairMale;
    public GameObject hairFemale;
    public bool isMale = true;

    public string username;
    public GameObject alertText;
    public GameObject alertTextR;

    private GameObject objPermanent;
    private Information informationCode;

    void Awake()
    {
        objPermanent = GameObject.Find("ObjectPermanent");
        informationCode = objPermanent.GetComponent<Information>();
    }
    
    void Update()
    {
        
    }

    public void ChangeHairColor(string r)
    {
        string[] colores = r.Split(',');
        Color color = new Color(float.Parse(colores[0]), float.Parse(colores[1]), float.Parse(colores[2]));
        hairM.color = color;
        hairF.color = color;
    }

    public void ChangeSkinColor(string r)
    {
        string[] colores = r.Split(',');
        Color color = new Color(float.Parse(colores[0]), float.Parse(colores[1]), float.Parse(colores[2]));
        skin.color = color;
    }

    public void ChangeTShirtColor(string r)
    {
        string[] colores = r.Split(',');
        Color color = new Color(float.Parse(colores[0]), float.Parse(colores[1]), float.Parse(colores[2]));
        tshirt.color = color;
    }

    public void ChangePantsColor(string r)
    {
        string[] colores = r.Split(',');
        Color color = new Color(float.Parse(colores[0]), float.Parse(colores[1]), float.Parse(colores[2]));
        pants.color = color;
    }

    public void SetUserName(string name)
    {
        alertText.SetActive(false);
        username = name;
    }

    public void SetGender()
    {
        isMale = !isMale;
        if (isMale)
        {
            hairMale.SetActive(true);
            hairFemale.SetActive(false);
            maleB.image.color = Color.green;
            femaleB.image.color = Color.white;
        }
        else
        {
            hairMale.SetActive(false);
            hairFemale.SetActive(true);
            maleB.image.color = Color.white;
            femaleB.image.color = Color.green;
        }
    }

    public void CreateNewUser()
    {
        if(username != "" && username != null)
        {
            int exists;
            exists = informationCode.SearchUser(username);
            if (exists == 1) 
            { 
                alertTextR.SetActive(true);
            }
            else
            {
                alertTextR.SetActive(false);
                informationCode.CreateNewUser(this.isMale, this.username, this.hairF.color, this.skin.color, this.tshirt.color, this.pants.color, 0, 0.0f);
            }
        }
        else
        {
            alertText.SetActive(true);
        }
    }
}
