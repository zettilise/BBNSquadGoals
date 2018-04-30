using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIScript : MonoBehaviour {

    public enum GUIState { selectionMenu, gameMenu, controlsMenu, endMenu } // 0, 1, 2
    public GUIState state = GUIState.selectionMenu;

    Button[][] uiButtons;
    Text[][] uiText;
    int[] opaqueness;
    
	// Use this for initialization
	void Start () {
        Button[][] tempButtons = {new Button[] { GameObject.Find("Info_Button").GetComponent<Button>(), GameObject.Find("Play_Button").GetComponent<Button>()},
            new Button[] { },
            new Button[] { GameObject.Find("Back_Button").GetComponent<Button>()},
            new Button[] { GameObject.Find("End_Button").GetComponent<Button>()}};

        uiButtons = tempButtons;

        Text[][] tempText = { new Text[] {GameObject.Find("Game_Title").GetComponent<Text>()},
            new Text[] { },
            new Text[] {GameObject.Find("Controls_Text").GetComponent<Text>(), GameObject.Find("Info_Text").GetComponent<Text>()},
            new Text[]{GameObject.Find("End_Text").GetComponent<Text>(), GameObject.Find("Score_Text").GetComponent<Text>()}};

        uiText = tempText;

        int[] tempOpaque = {1, 0, 1, 1};

        opaqueness = tempOpaque;

        for (int j = 0; j < uiButtons.Length;j++) {
            for (int i = 0; i < uiButtons[j].Length; i++)
            {
                uiButtons[j][i].gameObject.SetActive(false);
            }

            for (int i = 0; i < uiText[j].Length; i++)
            {
                uiText[j][i].gameObject.SetActive(false);
            }
        }

        for (int i = 0; i < uiButtons[convertStatetoNumber(GUIState.selectionMenu)].Length; i++)
        {
            uiButtons[convertStatetoNumber(GUIState.selectionMenu)][i].gameObject.SetActive(true);
        }

        for (int i = 0; i < uiText[convertStatetoNumber(GUIState.selectionMenu)].Length; i++)
        {
            uiText[convertStatetoNumber(GUIState.selectionMenu)][i].gameObject.SetActive(true);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public int convertStatetoNumber(GUIState s){
        switch(s){
            case GUIState.selectionMenu:
                return 0;
            case GUIState.gameMenu:
                return 1;
            case GUIState.controlsMenu:
                return 2;
            case GUIState.endMenu:
                return 3;
        }

        return -1;
    }

    public void switchScreen(GUIState newState){
        for (int i = 0; i < uiButtons[convertStatetoNumber(state)].Length; i++){
            uiButtons[convertStatetoNumber(state)][i].gameObject.SetActive(false);
        }

        for (int i = 0; i < uiText[convertStatetoNumber(state)].Length; i++)
        {
            uiText[convertStatetoNumber(state)][i].gameObject.SetActive(false);
        }

        for (int i = 0; i < uiButtons[convertStatetoNumber(newState)].Length; i++)
        {
            uiButtons[convertStatetoNumber(newState)][i].gameObject.SetActive(true);
        }

        for (int i = 0; i < uiText[convertStatetoNumber(newState)].Length; i++)
        {
            uiText[convertStatetoNumber(newState)][i].gameObject.SetActive(true);
        }

        state = newState;

        checkColor(convertStatetoNumber(newState));
    }

    public void checkColor(int index){
        GameObject.Find("Background").GetComponent<Image>().color = new Color(1f, 1f, 1f, opaqueness[index]);
    }

}
