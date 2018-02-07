// Holds game state variables that are accessible to all classes
public static class GameState {
	private static int numberOfSocks = 0;
	private static int score = 0;
	private static bool dogIsMoving = false;
	private static bool gameOver = false;
	private static string[] ratings = {
		"A total wash",
		"Clotheslined",
		"Hung out to dry",
		"Achilles Heel",
		"Laughing Sock",
		"A load of fun",
		"Head over heels",
		"Sock Star"
	};

	public static void MoveDog(){
		dogIsMoving = true;
	}

	public static void StopDog(){
		dogIsMoving = false;
	}

	public static bool GetDogIsMoving(){
		return dogIsMoving;
	}

	public static void UpdateScore(){
		if(!gameOver)
			score += 1;
	}

	public static int GetScore(){
		return score;
	}

	public static string GetRating(){
		if (score > ratings.Length - 1) {
			return ratings [ratings.Length - 1];
		}
		return ratings [score];
	}

	public static void AddSock(){
		numberOfSocks += 1;
	}

	public static void RemoveSock(){
		numberOfSocks -= 1;
	}

	public static int GetNumberOfSocks(){
		return numberOfSocks;
	}

	public static bool IsGameOver(){
		return gameOver;
	}

	public static void EndGame(){
		gameOver = true;
	}

	public static void StartGame(){
		gameOver = false;
		score = 0;
	}
}
