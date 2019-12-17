using UnityEngine;
using UnityEngine.UI;

public class ComputeSub : MonoBehaviour
{
    public Text result;
    public InputField inputField1;
    public InputField inputField2;
    public Button resetButton;
    public Button addButton;


    public void SetResult()
    {
        result.text = AddNumbers().ToString();
        inputField1.interactable = false;
        inputField2.interactable = false;
        addButton.interactable = false;
        resetButton.interactable = true;
    }

    public void Reset()
    {
        // reset inputFields
        inputField1.text = "0";
        inputField2.text = "0";
        result.text = "Result";

        // enable inputFields
        inputField1.interactable = true;
        inputField2.interactable = true;

        // activate needed Buttons
        addButton.interactable = true;
        resetButton.interactable = false;

    }
    private float AddNumbers()
    {
        float tempResult = float.Parse(inputField1.text) + float.Parse(inputField2.text);
        return tempResult;
    }


    private float SubNumbers()
    {
        float tempResult = float.Parse(inputField1.text) - float.Parse(inputField2.text);
        return tempResult;
    }

    public void OnClickSub()
    {
        result.text = SubNumbers().ToString();
        Debug.Log(SubNumbers());
    }

}