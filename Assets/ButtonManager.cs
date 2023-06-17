using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Button buttonB;
    public Button buttonE;
    public Button buttonG;
    public Button buttonC;
    public Button buttonY;
    public Button buttonZ;
    public Button buttonT;
    public Button buttonX;
    public Button buttonK;
    public Button buttonL;
    public Button buttonM;
    public Button buttonN;
    public Button buttonP;
    public Button buttonF;
    public Button buttonH;

    private bool buttonBClicked = false;
    private bool buttonEClicked = false;
    private bool buttonGClicked = false;
    private bool buttonYClicked = false;
    private bool buttonZClicked = false;
    private bool buttonTClicked = false;
    private bool buttonKClicked = false;
    private bool buttonLClicked = false;
    private bool buttonMClicked = false;
    private bool buttonNClicked = false;
    private bool buttonPClicked = false;

    private void Start()
    {
        buttonB.onClick.AddListener(ButtonBClicked);
        buttonE.onClick.AddListener(ButtonEClicked);
        buttonG.onClick.AddListener(ButtonGClicked);
        buttonY.onClick.AddListener(ButtonYClicked);
        buttonZ.onClick.AddListener(ButtonZClicked);
        buttonT.onClick.AddListener(ButtonTClicked);
        buttonK.onClick.AddListener(ButtonKClicked);
        buttonL.onClick.AddListener(ButtonLClicked);
        buttonM.onClick.AddListener(ButtonMClicked);
        buttonN.onClick.AddListener(ButtonNClicked);
        buttonP.onClick.AddListener(ButtonPClicked);
    }

    private void ButtonBClicked()
    {
        buttonBClicked = true;
        CheckButtons();
    }

    private void ButtonEClicked()
    {
        buttonEClicked = true;
        CheckButtons();
    }

    private void ButtonGClicked()
    {
        buttonGClicked = true;
        CheckButtons();
    }

    private void ButtonYClicked()
    {
        buttonYClicked = true;
        CheckButtons();
    }

    private void ButtonZClicked()
    {
        buttonZClicked = true;
        CheckButtons();
    }

    private void ButtonTClicked()
    {
        buttonTClicked = true;
        CheckButtons();
    }

    private void ButtonKClicked()
    {
        buttonKClicked = true;
        CheckButtons();
    }

    private void ButtonLClicked()
    {
        buttonLClicked = true;
        CheckButtons();
    }

    private void ButtonMClicked()
    {
        buttonMClicked = true;
        CheckButtons();
    }

    private void ButtonNClicked()
    {
        buttonNClicked = true;
        CheckButtons();
    }

    private void ButtonPClicked()
    {
        buttonPClicked = true;
        CheckButtons();
    }

    private void CheckButtons()
    {
        if (  (buttonKClicked && buttonLClicked && buttonPClicked )|| ( buttonKClicked && buttonMClicked && buttonNClicked))
        {
            buttonF.image.color = Color.green;
        }
        else
        {
            buttonF.image.color = Color.white;
        }

        if (buttonYClicked && buttonZClicked && buttonTClicked)
        {
            buttonX.image.color = Color.green;
        }
        else
        {
            buttonX.image.color = Color.white;
        }

        if (buttonBClicked && buttonEClicked && buttonGClicked)
        {
            buttonC.image.color = Color.green;
        }
        else
        {
            buttonC.image.color = Color.white;
        }

        if (buttonC.image.color == Color.green && buttonF.image.color == Color.green && buttonX.image.color == Color.green)
        {
            buttonH.image.color = Color.green;
        }
        else
        {
            buttonH.image.color = Color.white;
        }
    }
}





    




