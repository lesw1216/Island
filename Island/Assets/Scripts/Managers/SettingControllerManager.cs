using TMPro;
using UnityEngine;

namespace Managers
{
    public class SettingControllerManager : MonoBehaviour
    {
        public GameObject dropDown;

        public void OnChangeResolution()
        {
            var resolution = SetResolution(dropDown.GetComponent<TMP_Dropdown>());
            Debug.Log("width=" + resolution[0]);
            Debug.Log("height=" + resolution[1]);
            Debug.Log("해상도 변경");

            var resolutions = Screen.resolutions;
            Debug.Log("현재 width=" + resolutions[0]);
            Debug.Log("현재 height=" + resolutions[1]);
            // foreach (var t in resolutions)
            // {
            //     Debug.Log(t);
            // }
            Screen.SetResolution(resolution[0], resolution[1], false);

            Debug.Log(resolutions.ToString());
        }

        public static int[] SetResolution(TMP_Dropdown dropdown)
        {
            var dropdownOptions = dropdown.options;
            var selectIndex = dropdown.value;
            var setResolution = dropdownOptions[selectIndex].text;

            var setResolutionToArray = setResolution.Split('X');
            
            
            return new[]{int.Parse(setResolutionToArray[0]), int.Parse(setResolutionToArray[1])};
        } 
    }
    
}
