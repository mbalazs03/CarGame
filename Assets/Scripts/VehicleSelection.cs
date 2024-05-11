using UnityEngine;
using UnityEngine.UI;

public class VehicleSelection : MonoBehaviour
{
    public GameObject carPrefab; 
    public GameObject busPrefab;
    public GameObject selectedVehicle;

    void Start()
    {
        if (carPrefab == null || busPrefab == null)
        {
            Debug.LogError("Missing car or bus prefab!");
            return;
        }
    }

    public void SelectVehicle(int vehicleType)
    {    
        GameManager gameManager = FindObjectOfType<GameManager>();

        if (vehicleType == 1)
        {
            selectedVehicle = carPrefab;
            GameObject.Destroy(busPrefab);
            gameManager.StartGame();
        }
        else if (vehicleType == 2)
        {
            selectedVehicle = busPrefab;
            GameObject.Destroy(carPrefab);
            gameManager.StartGame();
        }
        else
        {
            Debug.LogWarning("Invalid vehicle type!");
        }
    }

}
