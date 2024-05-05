using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Hangman.WpfApp.Helpers;

internal static class FileHelper
{
	private static readonly string _filePath = Path.Combine(Environment.CurrentDirectory, "HangmanWords.txt");

	public static bool FileExists()
		=> File.Exists(_filePath);

	public static void CreateNewFile()
		=> File.AppendAllText(_filePath, "MODESTPROGGRAMER,PROGRAMISTA,KAZIMIERZ SZPIN");

	public static List<string> GetAvailableWords()
	{
		var textFile = File.ReadAllText(_filePath);

		return string.IsNullOrWhiteSpace(textFile)
			? throw new Exception("File is empty")
			: textFile.Split(',').Select(x => x.Trim()).ToList();
	}
}