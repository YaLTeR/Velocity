﻿using UnityEngine;
using System.Collections;

public class SaveData
{
	private int index;
	private string playerName;

	//Creates a new instance with given data
	public SaveData(int pIndex, string pPlayerName)
	{
		index = pIndex;
		playerName = pPlayerName;
	}

	//Creates a new instance with given data (for a later level)
	public SaveData(int pIndex, string pPlayerName, string pPlayerLevel, Vector3 pPlayerPos)
	{
		index = pIndex;
		playerName = pPlayerName;
	}

	//Creates a new instance from file saved at index
	public SaveData(int pIndex)
	{
		index = pIndex;
		playerName = PlayerPrefs.GetString("PlayerName" + pIndex.ToString());
	}

	public void save()
	{
		PlayerPrefs.SetString("PlayerName" + index.ToString(), playerName);
	}

	public string getPlayerName()
	{
		return playerName;
	}

	public int getIndex()
	{
		return index;
	}
}