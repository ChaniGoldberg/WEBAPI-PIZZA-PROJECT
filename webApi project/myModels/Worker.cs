using System;
using System.Collections.Generic;



namespace myModels;

public class Worker
{
    public string name { get; set; }

    public int age { get; set; }

    public int id { get; set; }
    
    public Worker(string name,int age,int id)
    {
        this.name=name;
        this.age=age;
        this.id=id;
    }
}