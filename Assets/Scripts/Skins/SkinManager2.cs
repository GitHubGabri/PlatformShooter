using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinManager2 : MonoBehaviour
{

    //Get things or stuff idk

    public GameObject SkinContainerObj;
    SkinsContainer SC;

    public Image IS;
    Image IM;
    public Image sSR;

    private int ActualPrice;

    public GameObject SelectButton;

    public Sprite UnSelectedSprite;
    public Sprite SelectedSprite;
    private static int AssignedSkin;
    private Image sr;
    public List<Sprite> skins = new List<Sprite>();
    public int SelectedSkin = 0;

    //Load data

    private void Start()
    {

        SC = SkinContainerObj.GetComponent<SkinsContainer>();

        sSR.sprite = skins[SelectedSkin];

        Load();

        CheckSkin();
    }

    public void NextOption()
    {

        SelectedSkin = SelectedSkin + 1;
        if (SelectedSkin == skins.Count)
        {

            SelectedSkin = 0;

        }

        sSR.sprite = skins[SelectedSkin];

        CheckSkin();

        Debug.Log("NextSkin");
    }
    public void BackOption()
    {

        SelectedSkin = SelectedSkin - 1;

        if (SelectedSkin < 0)
        {

            SelectedSkin = skins.Count - 1;

        }

        sSR.sprite = skins[SelectedSkin];

        CheckSkin();

        Debug.Log("BackSkin");
    }

    private void CheckSkin()
    {

        if (SelectedSkin == AssignedSkin)
        {

            SpriteSelected();

        }
        else
        {

            SpriteUnselected();

        }
    }

    private void SpriteSelected()
    {

        IS.sprite = SelectedSprite;

    }
    private void SpriteUnselected()
    {

        IS.sprite = UnSelectedSprite;

    }
    public void PlayGame()
    {

        Debug.Log("SelectSkin");

    }

    public void ConfirmSkin()
    {

        AssignedSkin = SelectedSkin;

        CheckSkin();
        Save();

    }

    public void End()
    {


        Save();
        sSR.sprite = skins[AssignedSkin];

        SkinsContainer.Prueba2 = 2;
        SkinsContainer.Selected2 = sSR.sprite;

    }

    public void Save()
    {
        //Selected

        PlayerPrefs.SetInt("SkinInt2", AssignedSkin);
        PlayerPrefs.Save();
        Debug.Log("Game skin saved!");
    }
    public void Load()
    {

        if (PlayerPrefs.HasKey("SkinInt"))
        {

            AssignedSkin = PlayerPrefs.GetInt("SkinInt2");
            Debug.Log("Game skin loaded!");

        }


        else

        {

            Debug.LogError("No skin founded");

        }
    }
}
