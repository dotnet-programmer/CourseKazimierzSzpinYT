using System;
using System.Linq;
using System.Windows.Data;
using TicTacToe.WpfApp.ViewModels;

namespace TicTacToe.WpfApp.Models;

public class Bindable2DArray<T>(int size1, int size2) : BaseViewModel
{
	private readonly T[,] _data = new T[size1, size2];

	public T this[int row, int col]
	{
		get => _data[row, col];
		set
		{
			_data[row, col] = value;
			OnPropertyChanged(Binding.IndexerName);
		}
	}

	public T this[string stringIndex]
	{
		get
		{
			(int, int) index = GetIndexes(stringIndex);
			return _data[index.Item1, index.Item2];
		}
		set
		{
			(int, int) index = GetIndexes(stringIndex);
			_data[index.Item1, index.Item2] = value;
			OnPropertyChanged(Binding.IndexerName);
		}
	}

	private (int, int) GetIndexes(string index)
	{
		var parts = index
			.Split('-')
			.Select(int.Parse)
			.ToArray();

		return parts.Length == 2
			? (parts[0], parts[1])
			: throw new ArgumentException("The provided index is not valid");
	}
}