using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarNivel : MonoBehaviour
{
    public void CambiarEscenaJuego(string juego)
    {
        SceneManager.LoadScene(juego);
    }

    public void CambiarEscenaMenu(string menuPrincipal)
    {
        SceneManager.LoadScene(menuPrincipal);
    }
}
