using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using AnotherFileBrowser.Windows;

public class MainMenuMatLoader : MonoBehaviour
{
    string path;
    public string BtnNameBfr = "LoadObj";
    public string BtnNameAft = "Loaded!";
    public string BtnNameErr = "Error, try again!";


    public void OpenFileBrowser()
    {
        var bp = new BrowserProperties();
        bp.filter = "Image Files (*.mtl)|*.mtl";
        bp.filterIndex = 0;
        bp.initialDir = @"C:\";

        new FileBrowser().OpenFileBrowser(bp, path =>
        {
            StateNameController.matRes = path;
            Debug.Log(path);
        });



    }


    //Não Utilizado
    //public void LoadMat()
    //{
    //    path = EditorUtility.OpenFilePanel("Load Mtl File", "", "mtl");
    //    PathCheck();
    //}

    //void PathCheck()
    //{
    //    if (path != null)
    //    {
    //        LoadPathMtl();
    //    }
    //}

    //void LoadPathMtl()
    //{

    //    StateNameController.pathRes = path;

    //    Debug.Log(StateNameController.pathRes);
    //}
}