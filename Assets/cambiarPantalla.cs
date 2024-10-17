using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class cambiarPantalla : MonoBehaviour
{
    public GameObject panelMenu;
    public GameObject panelJuego;
    public GameObject panelTienda;
    public GameObject panelInventario;
    public GameObject panelPausa;

    // Start is called before the first frame update
    void Start()
    {
        MostrarMenu();
    }
    public void MostrarMenu()
    {
        panelMenu.SetActive(true);
        panelJuego.SetActive(false);
        panelTienda.SetActive(false);
        panelInventario.SetActive(false);
        panelPausa.SetActive(false);
    }
    public void MostrarJuego()
    {
        panelMenu.SetActive(false);
        panelJuego.SetActive(true);
        panelTienda.SetActive(false);
        panelInventario.SetActive(false);
        panelPausa.SetActive(false);
    }
    public void MostrarTienda()
    {
        panelMenu.SetActive(false);
        panelJuego.SetActive(false);
        panelTienda.SetActive(true);
        panelInventario.SetActive(false);
        panelPausa.SetActive(false);
    }
    public void MostrarInventario()
    {
        panelMenu.SetActive(false);
        panelJuego.SetActive(false);
        panelTienda.SetActive(false);
        panelInventario.SetActive(true);
        panelPausa.SetActive(false);
    }
    public void MostrarPausa()
    {
        panelMenu.SetActive(false);
        panelJuego.SetActive(false);
        panelTienda.SetActive(false);
        panelInventario.SetActive(false);
        panelPausa.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (panelInventario.activeSelf)
            {
                MostrarJuego();
            }
            else if (panelJuego.activeSelf)
            {
                MostrarInventario();
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (panelPausa.activeSelf)
            {
                MostrarJuego();
            }
            else if (panelJuego.activeSelf)
            {
                MostrarPausa();
            }
        }
    }
}