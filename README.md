# Car Game
In this game, the player controls a car to collect all the coins scattered throughout the track as quickly as possible. 
The challenge lies in the fact that the positions of the coins are not visible in advance, and a pedestrian will cross the road during gameplay, adding to the difficulty.

#### Note
- Scripts location: Assets>Scripts

## GameManager
The `GameManager` script is responsible for managing the gameplay elements of a Unity game. It controls spawning coins, managing player interaction, and handling game over conditions.

### Usage
1. Call `StartGame()` to begin the game.
2. Collect coins by interacting with them in the scene.
3. The game ends when all coins are collected or when the time runs out.

### Examples
```csharp
    void Start() {...}
```
- Disable player controllers at the start of the game
- Set a random initial position for spawning coins
- Set up UI elements
#
```csharp
    public void StartGame() {...}
```
- Initiates the game by enabling player controllers and starting a countdown timer
#
```csharp
    IEnumerator Countdown() {...}
```
- A coroutine that counts down the time until the game ends
#
```csharp
    public void CoinPickedUp() {...}
```
- Called when a coin is collected, updates the coin counter, spawns a new coin, and checks for win conditions
#
```csharp
    void SpawnCoin() {...}
```
- Spawns a coin at a random position within predefined bounds
#
```csharp
    public void GameOver(bool isWin) {...}
```
- Ends the game, disables player controls, displays game over text, and freezes time   
#

## VehicleSelection

The `VehicleSelection` script allows the player to choose between controlling a car or a bus at the start of the game. 
It manages the selection of the vehicle type and initializes the game accordingly.


```csharp
public void SelectVehicle(int vehicleType) {...}
```

## PedestrianController

The `PedestrianController` script controls the behavior of a pedestrian character in the game. It manages the pedestrian's movement, animation, and rotation.

### Methods

```csharp 
void Start() {...}
```
- Description: Initializes the pedestrian controller.
- Functionality:
  - Retrieves the Animator component.
  - Sets the start location of the pedestrian.
  - Sets the pedestrian to start running.
#
```csharp 
void Update() {...}
```
- Description: Updates the pedestrian's movement.
- Functionality:
  - Moves the pedestrian towards the end location at a constant speed.
  - Checks if the pedestrian has reached the end location.
  - Stops the pedestrian animation and waits for a random amount of time before starting running again.
#
```csharp 
IEnumerator WaitAndStartRunning(float waitTime) {...}
```
- Description: Coroutine that waits for a specified amount of time and then starts the pedestrian running again.
- Parameters:
  - `waitTime` (float): The time to wait before starting running again.
#

