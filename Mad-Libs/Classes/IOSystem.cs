using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mad_Libs_App.Classes
{
	internal class IOSystem
	{
		public static string GetFirstString()
		{
			//file path for when we are still editing in vs
			string filePath = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "Text Files", "default.txt");
			if (!File.Exists(filePath))
			{
				//file for published app - above path should be removed before publishing, or we could keep it just in case.
				filePath = Path.Combine(AppContext.BaseDirectory, "Text Files", "default.txt");
			}
			string output = string.Empty;

			try
			{
				StreamReader sr = new StreamReader(filePath);
				string? o = sr.ReadLine();
				if (o != null) output = o;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				Clipboard.SetText(ex.Message);
			}
			return output;
		}
		public static string GetFirstString(string filePath)
		{
			//file path should always exist if we use OpenFileDialog to get txt files.
			string output = string.Empty;
			try
			{
				StreamReader sr = new StreamReader(filePath);
				string? o = sr.ReadLine();
				if (o != null) output = o;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			return output;
		}
		public static List<string> GetAllStrings()
		{
			//file path for when we are still editing in vs
			string filePath = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "Text Files", "default.txt");
			if (!File.Exists(filePath))
			{
				//file for published app - above path should be removed before publishing, or we could keep it just in case.
				filePath = Path.Combine(AppContext.BaseDirectory, "Text Files", "default.txt");
			}
			List<string> output = new List<string>();

			try
			{
				StreamReader sr = new StreamReader(filePath);
				string? o = sr.ReadLine();
				while (o != null)
				{
					output.Add(o);
					o = sr.ReadLine();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				Clipboard.SetText(ex.Message);
			}
			return output;
		}
		public static List<string> GetAllStrings(string filePath)
		{
			List<string> output = new List<string>();

			try
			{
				StreamReader sr = new StreamReader(filePath);
				string? o = sr.ReadLine();
				while (o != null)
				{
					output.Add(o);
					o = sr.ReadLine();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				Clipboard.SetText(ex.Message);
			}
			return output;
		}
	}
}
