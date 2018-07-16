using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

    public Transform player;
    public Text scoreText;
	
	// Update is called once per frame
	void Update () {
        if(FindObjectOfType<GameManager>().getGameHasEnded() == false)
        {
            scoreText.text = (0.1 *player.position.z).ToString("0");
        }
        
	}
}
