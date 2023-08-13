using System;

using R5T.T0131;


namespace R5T.Z0015
{
	[ValuesMarker]
	public partial interface IFilePaths : IValuesMarker
	{
		public string OutputErrorsTextFilePath => @"C:\Temp\Errors.txt";

		public string HumanOutputTextFilePath => @"C:\Temp\Human Output.txt";
		public string LogFilePath => @"C:\Temp\log.txt";
		public string OutputDataFilePath => @"C:\Temp\Output.dat";
        public string OutputHtmlFilePath => @"C:\Temp\Output.html";
        public string OutputJsonFilePath => @"C:\Temp\Output.json";
		public string OutputTextFilePath => @"C:\Temp\Output.txt";
        public string OutputTextFilePath_Secondary => @"C:\Temp\Output2.txt";
        public string OutputTextFilePath_Tertiary => @"C:\Temp\Output3.txt";
        public string OutputXmlFilePath => @"C:\Temp\Output.xml";
        public string RawOutputJsonFilePath => @"C:\Temp\Output-Raw.json";
		public string ResultOutputJsonFilePath => @"C:\Temp\Result.json";
	}
}