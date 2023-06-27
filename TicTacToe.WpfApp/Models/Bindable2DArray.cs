using System;
using System.Windows.Data;
using TicTacToe.WpfApp.ViewModels;

namespace TicTacToe.WpfApp.Models;

public class Bindable2DArray<T> : BaseViewModel
{
	private readonly T[,] _data;

	public Bindable2DArray(int size1, int size2) => _data = new T[size1, size2];

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
			var index = GetIndexes(stringIndex);
			return _data[index.Item1, index.Item2];
		}
		set
		{
			var index = GetIndexes(stringIndex);
			_data[index.Item1, index.Item2] = value;
			OnPropertyChanged(Binding.IndexerName);
		}
	}

	private (int, int) GetIndexes(string index)
	{
		var parts = index.Split('-');
		return parts.Length == 2
			? (int.Parse(parts[0]), int.Parse(parts[1]))
			: throw new ArgumentException("The provided index is not valid");
	}
}