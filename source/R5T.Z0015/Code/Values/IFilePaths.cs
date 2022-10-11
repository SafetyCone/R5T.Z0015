using System;

using R5T.T0131;


namespace R5T.Z0015
{
	[ValuesMarker]
	public partial interface IFilePaths : IValuesMarker
	{
		public string ResultOutputJsonFilePath => @"C:\Temp\Result.json";
	}
}