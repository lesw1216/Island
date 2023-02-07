using UnityEngine;
using UnityEngine.SceneManagement;

namespace Managers
{
    public class ButtonControllerManager : MonoBehaviour
    {
        public GameObject menuPanel;

        public AudioSource clickAudio;

        public GameObject mainDisplay;

        public GameObject settingDisplay;
        // public Image image;

        // 게임 시작
        public void OnClickStart()
        {
            Debug.Log("Click Start button");
            clickAudio.Play();
            SceneManager.LoadScene("MeetingRoom");
        }

        // 게임 설정 화면 이동
        public void OnClickOption()
        {
            Debug.Log("OnClickOption");
            mainDisplay.SetActive(false);
            settingDisplay.SetActive(true);
            clickAudio.Play();
        }

        // 게임 종료
        public void OnClickExit()
        {
            clickAudio.Play();
            Application.Quit();
            Debug.Log("EXIT BUTTON CLICK");
        }
        
        // 설정 화면에서 메인 메뉴로 이동
        public void OnClickToMainMenu()
        {
            Debug.Log("OnClickToMainMenu()");
            settingDisplay.SetActive(false);
            mainDisplay.SetActive(true);
            clickAudio.Play();
        }

        public void OnClickSave()
        {
            Debug.Log("Click setting save button");
            clickAudio.Play();
        }
    }
}
