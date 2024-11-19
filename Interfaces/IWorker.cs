using Microsoft.AspNetCore.Mvc;
using OrderManagement.Models;
using תשתית_לניהול_חנות_פיצה_חני_גולדברג;
public interface IWorker{
    public Worker GetId(int id);
    public Worker GetNmae(string name);
    public bool updateAge(int age,int id);
    public bool addWorker(string name,int age,int id);
    public Worker deleteWorker(int id);
}