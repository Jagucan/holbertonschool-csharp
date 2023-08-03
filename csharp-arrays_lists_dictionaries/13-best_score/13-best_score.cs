﻿using System;
using System.Collections.Generic;

class Dictionary
{
	public static string BestScore(Dictionary<string, int> myList)
	{
		string best = "";
		int bestScore = 0;

		if (myList == null)
		{
            return "None";
        }

		foreach (KeyValuePair<string, int> pair in myList)
        {
			if (pair.Value > bestScore)
            {
                best = pair.Key;
                bestScore = pair.Value;
            }
		}
		return best;
	}
}
