﻿namespace Single_Responsibility_Principle.DataAccess;

class StringsTextualRepository
{
    private static readonly string Seperator = Environment.NewLine;
    public List<string> Read(string filePath)
    {
        var fileContents = File.ReadAllText(filePath);
        return fileContents.Split(Seperator).ToList();

    }

    public void Write(string filePath, List<string> strings)
    {
        File.WriteAllText(filePath, string.Join(Seperator, strings));
    }
}


