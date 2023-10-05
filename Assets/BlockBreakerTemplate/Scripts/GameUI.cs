using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameUI : MonoBehaviour 
{
	public GameManager manager;		//The GameManager

	public Text scoreText;			//The Text component that will display the score
	public Text livesText;			//The Text component that will display the lives

	public GameObject gameOverScreen;	//The game over screen game object
	public Text gameOverScoreText;	//The Text component that will display the score when the player lost

	public GameObject winScreen;	//The win screen game object

	void Update ()
	{
		if(!manager.gameOver && !manager.wonGame){					//If the game is not over or the game has not been won
			scoreText.text = "<b>SCORE</b>\n" + manager.score;		//Sets the scoreText to display the words 'SCORE' in bold and then the score value on a new line which is located in the GameManager class
			livesText.text = "<b>LIVES</b>: " + manager.lives;		//Sets the livesText to display the words 'LIVES' in bold and then the lives value which is located in the GameManager class
		}else{														//Else if it is over or won
			scoreText.text = "";
			livesText.text = "";
		}
	}

	//Called when the game is over
	public void SetGameOver ()
	{
		gameOverScreen.active = true;
		gameOverScoreText.text = "<b>YOU ACHIEVED A SCORE OF</b>\n" + manager.score;	//Sets the gameOverScoreText to display the words 'YOU ACHIEVED A SCORE OF' in bold and then the score value on a new line which is located in the GameManager class
	}

	//Called when the game has been won
	public void SetWin ()
	{
		winScreen.active = true;
	}

	//Called when the 'TRY AGAIN' button is pressed
	public void TryAgainButton ()
	{
		gameOverScreen.active = false;
		winScreen.active = false;
		manager.StartGame();
	}

	//Called when the 'MENU' button is pressed
	public void MenuButton ()
	{
		Application.LoadLevel(0);	//Loads the 'Menu' scene
	}
}
