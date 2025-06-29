using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController3 : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> buttons;
    [SerializeField]
    private string showAnimationName;
    [SerializeField]
    private string hideAnimationName;
    [SerializeField]
    private float showButtonsDelay = 0.1f;
    public void ShowButtons()
    {
        StartCoroutine(ShowButtonsCoroutine());
    }

    private IEnumerator ShowButtonsCoroutine()
    {
        for (int i = 0; i < buttons.Count; i++)
        {
            buttons[i].GetComponent<Animator>().Play(showAnimationName);
            yield return new WaitForSeconds(showButtonsDelay);
        }
    }

    public void HideButtons()
    {
        foreach (GameObject button in buttons)
        {
            button.GetComponent<Animator>().Play(hideAnimationName);
        }
    }
}
