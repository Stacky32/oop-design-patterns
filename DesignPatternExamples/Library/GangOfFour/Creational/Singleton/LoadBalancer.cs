using System;
using System.Collections.Generic;

namespace Library.GangOfFour.Creational.Singleton;

public sealed class LoadBalancer
{
    private static readonly LoadBalancer instance = new();

    private readonly List<Server> servers;
    private readonly Random random = new();

    private LoadBalancer()
    {
        servers = [
            new(Name: "ServerI", Ip: "120.12.220.43"),
            new(Name: "ServerII", Ip: "121.34.170.43"),
            new(Name: "ServerIII", Ip: "45.125.220.0"),
            new(Name: "ServerIV", Ip: "42.12.220.43"),
            new(Name: "ServerV", Ip: "132.12.220.43"),
        ];
    }

    public static LoadBalancer GetLoadBalancer() => instance;

    public Server NextServer => servers[random.Next(servers.Count)];
}