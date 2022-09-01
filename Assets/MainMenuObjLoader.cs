using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using AnotherFileBrowser.Windows;
public class MainMenuObjLoader : MonoBehaviour
{
    //string _path;
    //public Button openExplorerButton;
    public bool ObjLoaded = false;

    public void OpenFileBrowser()
    {
        var bp = new BrowserProperties();
        bp.filter = "OBJ model files (*.obj)|*.obj";
        bp.filterIndex = 0;
        bp.initialDir = @"C:\";

        new FileBrowser().OpenFileBrowser(bp, path =>
        {
            StateNameController.pathRes = path;
            Debug.Log(path);
        });

        
    }


    //Não Utilizado
    //public void LoadObj()
    //{
    //    path = EditorUtility.OpenFilePanel("Load Obj File", "", "obj");
    //    PathCheck();
    //}

    //void PathCheck()
    //{
    //    if (path != null)
    //    {
    //        LoadPathObj();
    //    }
    //}

    //void LoadPathObj()
    //{
    //    
    //    StateNameController.pathRes = path;

    //    Debug.Log(StateNameController.pathRes);
}

