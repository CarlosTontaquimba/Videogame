using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [Range(0f, 0.02f)]
    public float parallaxSpeed = 0.02f;
    public RawImage background, platform;
    public GameObject uiIdle;
    public enum GameState {Idle, Playing};
    public GameState gameState = GameState.Idle;

    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Cambiamos de estado si el juego esta parado y presionamos algun boton
        if(gameState == GameState.Idle && (Input.GetKeyDown("up") || Input.GetMouseButtonDown(0)))
        {
            gameState = GameState.Playing;
            //Se quita el texto al momento de iniciar el juego
            uiIdle.SetActive(false);
            //Cambiamos de estado a correr cuando inicie el juego
            player.SendMessage("UpdateState","PlayerRun");  
        }else if (gameState == GameState.Playing)
        {
            Parallax();
        }
    }
    public void Parallax()
    {
        float finalSpeed = parallaxSpeed * Time.deltaTime;
        background.uvRect = new Rect(background.uvRect.x+finalSpeed, 0f,1f,1f);
        platform.uvRect = new Rect(platform.uvRect.x+finalSpeed*4, 0f,1f,1f);
    }
}
