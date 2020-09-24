using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Runtime.InteropServices;


public class ScreenshotPreview : MonoBehaviour
{

    [SerializeField]
    public GameObject canvas;
    string[] file;




    // Use this for initialization
    void Start()
    {
        file = Directory.GetFiles(Application.persistentDataPath + "/", "*.png");

        if (file.Length > 0)
        {

            GetPictureAndShowIt();
        }
    }



    void GetPictureAndShowIt()
    {
        string pathToFile = file[0];
        Texture2D texture = GetScreenshotImage(pathToFile);
        Sprite sp = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height),
            new Vector2(0.5f, 0.5f));
        canvas.GetComponent<Image>().sprite = sp;
    }

    Texture2D GetScreenshotImage(string filePath)
    {
        Texture2D texture = null;
        byte[] fileBytes;
        if (File.Exists(filePath))
        {
            fileBytes = File.ReadAllBytes(filePath);
            texture = new Texture2D(2, 2, TextureFormat.RGB24, false);
            texture.LoadImage(fileBytes);
        }
        return texture;
    }

    public void ShareAndroid()
    {
        string path;
        path = file[0];
        byte[] fileBytes;

        if (File.Exists(path))
        {

            fileBytes = File.ReadAllBytes(path);


            File.WriteAllBytes(path, fileBytes);




            if (!Application.isEditor)
            {
                // block to open the file and share it ------------START
                AndroidJavaClass intentClass = new AndroidJavaClass("android.content.Intent");
                AndroidJavaObject intentObject = new AndroidJavaObject("android.content.Intent");
                intentObject.Call<AndroidJavaObject>("setAction", intentClass.GetStatic<string>("ACTION_SEND"));
                AndroidJavaClass uriClass = new AndroidJavaClass("android.net.Uri");
                AndroidJavaObject uriObject = uriClass.CallStatic<AndroidJavaObject>("parse", "file://" + path);
                intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_STREAM"), uriObject);

                intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_TEXT"), "/nhttps://play.google.com/store/apps/details?id=com");




                intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_SUBJECT"), "Hello THERE");
                intentObject.Call<AndroidJavaObject>("setType", "image/jpeg");

                AndroidJavaClass unity = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
                AndroidJavaObject currentActivity = unity.GetStatic<AndroidJavaObject>("currentActivity");

                // option one WITHOUT chooser:
                currentActivity.Call("startActivity", intentObject);

                // block to open the file and share it ------------END

            }
        }


    }







    public void ShareIOS()
    {
        string path;
        path = file[0];
        byte[] fileBytes;


        if (!Application.isEditor)
        {

            fileBytes = File.ReadAllBytes(path);


            File.WriteAllBytes(path, fileBytes);






            IOSSharing.Shareimage(path, "link");


        }


    }

}


 



public static class IOSSharing{

    [DllImport("__Internal")]
    private static extern void _NativeShare_Share(string files,string message);

    public static void Shareimage(string path,string message)

    {
        _NativeShare_Share(path, message);  


    }

        

    }








