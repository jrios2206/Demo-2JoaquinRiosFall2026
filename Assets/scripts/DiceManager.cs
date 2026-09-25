using UnityEngine;
using TMPro;
public class DiceManager : MonoBehaviour
{
    public TMP_Text diceNumberText;
    public GameObject action1;
    public GameObject action2;
    public GameObject action3;
    public GameObject action4; 
    public int roundsRemaining;
    public int badActionIndex;
    public GameObject winText;
    public GameObject loseText;
   
    
    public void RollDice()
    { 
        roundsRemaining = Random.Range(1, 7); // generating random number b/e 1 and 7
        diceNumberText.text = roundsRemaining.ToString(); // displaying the number we got from the random generator
        //displaying our options
        action1.SetActive(true);
        action2.SetActive(true);
        action3.SetActive(true);
        action4.SetActive(true);
        PickBadAction(); // this ill get me a bad action to lose the game
    }

    
    void PickBadAction()
    {
        badActionIndex = Random.Range(1, 5);//getting random bad choice from the indexes [i]
    }

    void LoseGame()
    {
        action1.SetActive(false);
        action2.SetActive(false);
        action3.SetActive(false);
        action4.SetActive(false);
        loseText.SetActive(true);
    }

    void WinGame()
    {
        action1.SetActive(false);
        action2.SetActive(false);
        action3.SetActive(false);
        action4.SetActive(false);
        winText.SetActive(true);
    }

    public void PickGoodAction(int goodAction)
    {
        if (goodAction == badActionIndex)
        {
            LoseGame();
        }
        else
        {
            roundsRemaining--;
            if (roundsRemaining == 0)
            {
                WinGame();
            }
            else
            {
                PickBadAction();
            }
        } 
    }

}
