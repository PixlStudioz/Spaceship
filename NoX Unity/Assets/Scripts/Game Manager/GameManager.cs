using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject objectToSpawn;

    public Transform spawnpoint;

    public List<DeathVolume> deathVolumeList = new List<DeathVolume>();

    public static GameManager instance;

    // Game States
    public GameObject TitleScreenStateObject;
    public GameObject MainMenuStateObject;
    public GameObject OptionsScreenStateObject;
    public GameObject CreditsScreenStateObject;
    public GameObject GameplayStateObject;
    public GameObject GameOverScreenStateObject;

    public void Awake()
    {
        if(instance == null)
        {
            instance = this;

            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (objectToSpawn != null && spawnpoint != null)
        {
            Instantiate(objectToSpawn, spawnpoint.position, spawnpoint.rotation);
        }

        ActivateTitleScreen();
    }
    void Update()
    {
        
    }

    private void DeactivateAllStates()
    {
        TitleScreenStateObject.SetActive(false);
        MainMenuStateObject.SetActive(false);
        OptionsScreenStateObject.SetActive(false);
        CreditsScreenStateObject.SetActive(false);
        GameplayStateObject.SetActive(false);
        GameOverScreenStateObject.SetActive(false);
    }
    public void ActivateTitleScreen()
    {
        DeactivateAllStates();
        TitleScreenStateObject.SetActive(true);
    }

    public void ActivateMainMenu()
    {
        DeactivateAllStates();
        MainMenuStateObject.SetActive(true);
    }

    public void ActivateOptions()
    {
        DeactivateAllStates();
        OptionsScreenStateObject.SetActive(true);
    }

    public void ActivateCredits()
    {
        DeactivateAllStates();
        CreditsScreenStateObject.SetActive(true);
    }

    public void ActivateGameplay()
    {
        DeactivateAllStates();
        GameplayStateObject.SetActive(true);
    }

    public void ActivateGameOver()
    {
        DeactivateAllStates();
        GameOverScreenStateObject.SetActive(true);
    }
}
