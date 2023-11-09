using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class ControladorPausa: MonoBehaviour
{
    private InputSystem playerControls;
    private InputAction menuPausa;

    [SerializeField] private GameObject PauseMenu;
    [SerializeField] private bool isPaused;


    private void Awake()
    {
        playerControls = new InputSystem();
    }

    private void OnEnable()
    {
        menuPausa = playerControls.UI.Escape;
        menuPausa.Enable();

        menuPausa.performed += Pause;
    }

    private void OnDisable()
    {
        menuPausa.Disable();
    }

    public void Pause(InputAction.CallbackContext context)
    {
        isPaused = !isPaused;
        if (isPaused)
        {
            ActivateMenu();
        }
        else
        {
            DeactivateMenu();
        }
    }

    void ActivateMenu()
    {
        Time.timeScale = 0;
        AudioListener.pause = true;
        PauseMenu.SetActive(true);
    }

    public void DeactivateMenu()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
        PauseMenu.SetActive(false);
        isPaused = false;
    }
}
