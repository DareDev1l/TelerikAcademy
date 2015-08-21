using System;

//Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts
//from it the [protocol], [server] and [resource] elements.
class Program
{
    static void ParseUrl(string url)
    {
        int protocolStart = 0;
        int protocolEnd = url.IndexOf(@"://");
        int serverStart = protocolEnd + 3;
        int serverEnd = url.IndexOf("/", protocolEnd + 4);
        

        Console.WriteLine("[protocol] = {0}", url.Substring(protocolStart, protocolEnd));
        Console.WriteLine("[server] = {0}", url.Substring(serverStart, serverEnd - serverStart));
        Console.WriteLine("[resource] = {0}", url.Substring(serverEnd));
    }
    static void Main(string[] args)
    {
        string url = @"http://telerikacademy.com/Courses/Courses/Details/212";

        ParseUrl(url);
    }
}