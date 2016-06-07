using UnityEngine;
using System.Collections;
using System.IO;
using System.Text;
using UnityEngine;
using CsvHelper;

public class App : MonoBehaviour {

	// Use this for initialization
	void Start () {

		TextAsset csv = Resources.Load( "sample" ) as TextAsset;

		StringReader    strReader = new StringReader(csv.text);
		CsvReader       csvReader = new CsvReader(strReader);

		while (csvReader.Read())
		{
			string[] records = csvReader.CurrentRecord;
			Debug.Log(records[0]);
			Debug.Log(records[1]);
			Debug.Log(records[2]);
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
