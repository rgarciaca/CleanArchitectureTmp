// See https://aka.ms/new-console-template for more information
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;

Console.WriteLine("Hello, World!");


string authoB64 = "YWRtLmxpZmVkZXM6TGlmM1JheT8=";
string autho = "adm.lifedes:Lif3Ray?";
//string newautho = "adm.lifepre:Lif3Raypr3?";
string newautho = "adm.lifepro:Lif3Raypr0?";

byte[] plainTextBytes = System.Text.Encoding.UTF8.GetBytes(newautho);
string newauthoB64 = Convert.ToBase64String(plainTextBytes);

SHA256 mySHA256 = SHA256.Create();

byte[] hasValue = mySHA256.ComputeHash(Convert.FromBase64String(newauthoB64));

StringBuilder output = new StringBuilder();
for (int i = 0; i < hasValue.Length; i++)
    output.Append(hasValue[i].ToString("x2").ToLower());

Console.WriteLine(output.ToString());
Console.ReadLine();