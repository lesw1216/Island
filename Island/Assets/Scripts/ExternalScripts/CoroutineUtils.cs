// using System.Collections;
// using Microsoft.Unity.VisualStudio.Editor;
// using UnityEngine;
// using Image = UnityEngine.UI.Image;
//
// namespace ExternalScripts
// {
//     public static class CoroutineUtils
//     {
//         public static IEnumerator FadeOutByCoroutine(Image backGround)
//         {
//             float fadeCount = 0;
//             while (fadeCount < 1.0f)
//             {
//                 fadeCount += 0.01f;
//                 yield return new WaitForSeconds(0.01f);
//                 backGround.color = new Color(0, 0, 0, fadeCount);
//             }
//         }
//     }
// }