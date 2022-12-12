using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelection : MonoBehaviour
{
    private byte[] fileData;
    private int max = 6, min = 0, counter = 0;
    private Sprite[] profilepictures = new Sprite[7];
    public Button NextButton, Submitbutton;
    public Image imageToDisplay, MaleFrame, FemaleFrame;
    [SerializeField] private Player player;
    // Start is called before the first frame update
    void Start()
    {
        profilepictures[0] = Resources.Load<Sprite>("ProfilePictures/mrcamel");
        profilepictures[1] = Resources.Load<Sprite>("ProfilePictures/coolcamel");
        profilepictures[2] = Resources.Load<Sprite>("ProfilePictures/girlwithglasses");
        profilepictures[3] = Resources.Load<Sprite>("ProfilePictures/maleshadow");
        profilepictures[4] = Resources.Load<Sprite>("ProfilePictures/erenanime");
        profilepictures[5] = Resources.Load<Sprite>("ProfilePictures/baldestmanaliveanime");
        profilepictures[6] = Resources.Load<Sprite>("ProfilePictures/yokanime");
        imageToDisplay.sprite = profilepictures[counter];
        player.image.sprite = imageToDisplay.sprite;
    }
    public void NextPicture()
    {
        counter++;
        if (counter > max)
        {
            imageToDisplay.sprite = profilepictures[min];
            player.image.sprite = imageToDisplay.sprite;
            counter = min;
        }
        else
        {
            imageToDisplay.sprite = profilepictures[counter];
            player.image.sprite = imageToDisplay.sprite;
        }
        UnityEngine.Debug.Log("Next Image number = " + counter);
    }

    public void PreviousPicture()
    {
        counter--;
        if(counter < min)
        {
            imageToDisplay.sprite = profilepictures[max];
            player.image.sprite = imageToDisplay.sprite;
            counter = max;
        }
        else
        {
            imageToDisplay.sprite = profilepictures[counter];
            player.image.sprite = imageToDisplay.sprite;
        }
        UnityEngine.Debug.Log("Previous Image number = " + counter);
    }

    public void Upload()
    {
        string path = UnityEditor.EditorUtility.OpenFilePanel("Open image", "", "jpg,png,bmp");
        if (!System.String.IsNullOrEmpty(path))
        {
            fileData = File.ReadAllBytes(path);
            Texture2D tex = new Texture2D(2, 2);
            tex.LoadImage(fileData);
            Rect rec = new Rect(0, 0, tex.width, tex.height);
            Sprite spriteToUse = Sprite.Create(tex, rec, new Vector2(0.5f, 0.5f), 100);
            imageToDisplay.sprite = spriteToUse;
            player.image.sprite = imageToDisplay.sprite;
        }
    }
    
    public void ReadStringInput(string name)
    {
        if (name != null && name != "")
        {
            player.Pusername = name;
            UnityEngine.Debug.Log("Username is set to = " + player.Pusername);
            Submitbutton.interactable = true;
        }
        else
        {
            Submitbutton.interactable = false;
        }
    }

    public void MaleSelection()
    {
        FemaleFrame.enabled = false;
        player.Pgender = "Male";
        NextButton.interactable = true;
    }

    public void FemaleSelection()
    {
        MaleFrame.enabled = false;
        player.Pgender = "Female";
        NextButton.interactable = true;
    }
}
