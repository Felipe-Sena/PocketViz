using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Dummiesman;

public class ObjLoader : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject loadedObject;
    void Start()
    {
        string filePath = StateNameController.pathRes;
        string mat = StateNameController.matRes;
        Debug.Log(filePath);
        Debug.Log(mat);

        //Material newMat = new Material(Shader.Find("Unlit"));

        //Ver se o arquivo existe
        if (!File.Exists(filePath))
        {
            Debug.LogError("OBJECT DOESN'T EXIST");
        }
        else
        {
            //Ver se o objeto carregado (UNITY INTERNAL) existe
            if (loadedObject != null)
                Destroy(loadedObject);
            if (mat == "") //Se o material for inexistente
            {
                loadedObject = new OBJLoader().Load(filePath);
                Debug.Log("No mat");
            }
            else
            {
                loadedObject = new OBJLoader().Load(filePath, mat);
            }
        }


        // Update is called once per frame
        //void Update()
        //{

        //}
    }
}
