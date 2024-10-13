using UnityEngine;
using UnityEngine.UI;

public class DisplayPlayerName : MonoBehaviour
{
    public Text playerNameDisplay;
    void Start()
    {
        playerNameDisplay.text = GameManager.instance.playerName;
    }
}
