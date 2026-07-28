using System;
using System.Collections.Generic;

public static class DialingCodes
{
    public static Dictionary<int, string> GetEmptyDictionary()
        => new Dictionary<int, string>();

    public static Dictionary<int, string> GetExistingDictionary()
        => new Dictionary<int, string>() 
    {
        [1] = "United States of America",
        [55] = "Brazil",
        [91] = "India"
    };

    public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
    {
        var dictionary = GetEmptyDictionary();
        dictionary.Add(countryCode, countryName);
        return dictionary;
    }

    public static Dictionary<int, string> AddCountryToExistingDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        existingDictionary.Add(countryCode, countryName);
        return existingDictionary;
    }

    public static string GetCountryNameFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        foreach(int key in existingDictionary.Keys)
        {
            if (key == countryCode)
            {
                return existingDictionary[countryCode];
            }
        }
        return "";
    }

    public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
    {
        foreach(int key in existingDictionary.Keys)
        {
            if (key == countryCode)
            {
                return true;
            }
        }
        return false;
    }

    public static Dictionary<int, string> UpdateDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        foreach(int key in existingDictionary.Keys)
        {
            if (key == countryCode)
            {
                existingDictionary[key] = countryName;
                return existingDictionary;
            }
        }
        return existingDictionary;
    }

    public static Dictionary<int, string> RemoveCountryFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        foreach(int key in existingDictionary.Keys)
        {
            if (key == countryCode)
            {
                existingDictionary.Remove(countryCode);
                return existingDictionary;
            }
        }
        return existingDictionary;
    }

    public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
    {
        int counter = 0;
        string result = string.Empty;
        
        foreach(var entry in existingDictionary)
        {
            if (entry.Value.Length > counter)
            {
                counter = entry.Value.Length;
                result = entry.Value;
            }
        }
        return result;
    }
}