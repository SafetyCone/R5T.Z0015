using System;

using R5T.T0131;


namespace R5T.Z0015
{
	[ValuesMarker]
	public partial interface IFilePaths : IValuesMarker
	{
		public string OutputJsonFilePath => @"C:\Temp\Output.json";
		public string OutputTextFilePath => @"C:\Temp\Output.txt";
		public string ResultOutputJsonFilePath => @"C:\Temp\Result.json";
	}
}