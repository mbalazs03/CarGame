# Car Game
In this game, the player controls a car to collect all the coins scattered throughout the track as quickly as possible. 
The challenge lies in the fact that the positions of the coins are not visible in advance, and a pedestrian will cross the road during gameplay, adding to the difficulty.

## GameManager
The `GameManager` script is responsible for managing the gameplay elements of a Unity game. It controls spawning coins, managing player interaction, and handling game over conditions.

### Features
- **StartGame():** Initiates the game by enabling player controllers and starting a countdown timer.
- **Countdown():** A coroutine that counts down the time until the game ends.
- **CoinPickedUp():** Called when a coin is collected, updates the coin counter, spawns a new coin, and checks for win conditions.
- **SpawnCoin():** Spawns a coin at a random position within predefined bounds.
- **GameOver():** Ends the game, disables player controls, displays game over text, and freezes time.

### Usage
1. Call `StartGame()` to begin the game.
2. Collect coins by interacting with them in the scene.
3. The game ends when all coins are collected or when the time runs out.

### Example
```csharp
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        // Disable player controllers at the start of the game
        // Set a random initial position for spawning coins
        // Set up UI elements
    }

    public void StartGame()
    {
        // Initiates the game by enabling player controllers and starting a countdown timer
    }

    IEnumerator Countdown()
    {
        // A coroutine that counts down the time until the game ends
    }

    public void CoinPickedUp()
    {
        // Called when a coin is collected, updates the coin counter, spawns a new coin, and checks for win conditions
    }

    void SpawnCoin()
    {
        // Spawns a coin at a random position within predefined bounds
    }

    public void GameOver(bool isWin)
    {
        // Ends the game, disables player controls, displays game over text, and freezes time       
    }
}

```
