using System;
using System.Runtime.InteropServices;

public class Win32PlaySound
{
	[DllImport("winmm.dll")]
	public static extern bool PlaySound(string pszSound , int hmod , int fdwSound );
}
