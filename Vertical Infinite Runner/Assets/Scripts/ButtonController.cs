using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MrKGame
{
    /*summary :ButtonController is controlling all button in menuUI , gameplayUI and help UI  */

    public class ButtonController : MonoBehaviour
    {
        [SerializeField] public string gamePlaySceneName;
        [SerializeField] public string menuSceneName;
        [SerializeField] public GameObject pauseButtonUI;
        [SerializeField] public GameObject helpButtonUI;
        private bool isPaused;

        /*OnPlayOrRestartButtonClick : this function is help on play or restart button click by loading scene
                                        also plays music of button click and set time scale to 1*/
        public void OnPlayOrRestartButtonClick()
        {
            SoundManager.Instance.Play(Sounds.ButtonClick);
            SceneManager.LoadScene(gamePlaySceneName);
            Time.timeScale = 1;
        }


        /*OnMenuClick : this function is help on Menu Button click Loads menu scene
                                        also plays music of button click and set time scale to 0*/

        public void OnMenuClick()
        {
            SoundManager.Instance.Play(Sounds.ButtonClick);
            SceneManager.LoadScene(menuSceneName);
            Time.timeScale = 0;
        }


        /*OnQuitButtonClick : this function is help on Quit Button click,plays music of button click 
                                        and will quit the game */

        public void OnQuitButtonClick()
        {
            SoundManager.Instance.Play(Sounds.ButtonClick);
            Application.Quit();
        }

        void Update()
        {
            OnPauseButtonClick();
        }


        /*OnPauseButtonClick : this methos is use for checking "Esc" button click*/

        void OnPauseButtonClick()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                SoundManager.Instance.Play(Sounds.ButtonClick);
                isPaused = !isPaused;
                PauseGame();
            }
        }

        /*PauseGame : this function is help on "Esc" Button click Loads pause UI
                                        also plays music of button click and set time scale to 0
                                        and after clicking again will Resume the scene*/

        public void PauseGame()
        {

            if (isPaused)
            {
                Time.timeScale = 0f;
                pauseButtonUI.gameObject.SetActive(true);
            }
            else
            {
                Time.timeScale = 1f;
                pauseButtonUI.gameObject.SetActive(false);
            }

        }

        /*OnHelpButtonClick : this function is help on "Help" Button click Loads Help UI
                                also plays music of button click */

        public void OnHelpButtonClick()
        {
            SoundManager.Instance.Play(Sounds.ButtonClick);
            helpButtonUI.gameObject.SetActive(true);
        }

        /*OnBackButtonClick : this function is help on "Back" Button click Loads Help UI
                        also plays music of button click */

        public void OnBackButtonClick()
        {
            SoundManager.Instance.Play(Sounds.ButtonClick);
            helpButtonUI.gameObject.SetActive(false);
        }


    }
}