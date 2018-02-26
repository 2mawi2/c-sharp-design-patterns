using System;

namespace DesignPatterns
{
    interface IApi
    {
        string DoSth();
    }

    public class Api : IApi
    {
        public string DoSth() => "doing sth";
    }

    public class ApiProxy : IApi
    {
        public string DoSth() => "proxy";
    }
}